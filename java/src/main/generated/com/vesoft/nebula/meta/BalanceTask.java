/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
package com.vesoft.nebula.meta;

import org.apache.commons.lang.builder.HashCodeBuilder;
import java.util.List;
import java.util.ArrayList;
import java.util.Map;
import java.util.HashMap;
import java.util.Set;
import java.util.HashSet;
import java.util.Collections;
import java.util.BitSet;
import java.util.Arrays;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;

import com.facebook.thrift.*;
import com.facebook.thrift.async.*;
import com.facebook.thrift.meta_data.*;
import com.facebook.thrift.server.*;
import com.facebook.thrift.transport.*;
import com.facebook.thrift.protocol.*;

@SuppressWarnings({ "unused", "serial" })
public class BalanceTask implements TBase, java.io.Serializable, Cloneable, Comparable<BalanceTask> {
  private static final TStruct STRUCT_DESC = new TStruct("BalanceTask");
  private static final TField ID_FIELD_DESC = new TField("id", TType.STRING, (short)1);
  private static final TField RESULT_FIELD_DESC = new TField("result", TType.I32, (short)2);

  public byte[] id;
  /**
   * 
   * @see TaskResult
   */
  public int result;
  public static final int ID = 1;
  public static final int RESULT = 2;
  public static boolean DEFAULT_PRETTY_PRINT = true;

  // isset id assignments
  private static final int __RESULT_ISSET_ID = 0;
  private BitSet __isset_bit_vector = new BitSet(1);

  public static final Map<Integer, FieldMetaData> metaDataMap;
  static {
    Map<Integer, FieldMetaData> tmpMetaDataMap = new HashMap<Integer, FieldMetaData>();
    tmpMetaDataMap.put(ID, new FieldMetaData("id", TFieldRequirementType.DEFAULT, 
        new FieldValueMetaData(TType.STRING)));
    tmpMetaDataMap.put(RESULT, new FieldMetaData("result", TFieldRequirementType.DEFAULT, 
        new FieldValueMetaData(TType.I32)));
    metaDataMap = Collections.unmodifiableMap(tmpMetaDataMap);
  }

  static {
    FieldMetaData.addStructMetaDataMap(BalanceTask.class, metaDataMap);
  }

  public BalanceTask() {
  }

  public BalanceTask(
    byte[] id,
    int result)
  {
    this();
    this.id = id;
    this.result = result;
    setResultIsSet(true);
  }

  /**
   * Performs a deep copy on <i>other</i>.
   */
  public BalanceTask(BalanceTask other) {
    __isset_bit_vector.clear();
    __isset_bit_vector.or(other.__isset_bit_vector);
    if (other.isSetId()) {
      this.id = TBaseHelper.deepCopy(other.id);
    }
    this.result = TBaseHelper.deepCopy(other.result);
  }

  public BalanceTask deepCopy() {
    return new BalanceTask(this);
  }

  @Deprecated
  public BalanceTask clone() {
    return new BalanceTask(this);
  }

  public byte[]  getId() {
    return this.id;
  }

  public BalanceTask setId(byte[] id) {
    this.id = id;
    return this;
  }

  public void unsetId() {
    this.id = null;
  }

  // Returns true if field id is set (has been assigned a value) and false otherwise
  public boolean isSetId() {
    return this.id != null;
  }

  public void setIdIsSet(boolean value) {
    if (!value) {
      this.id = null;
    }
  }

  /**
   * 
   * @see TaskResult
   */
  public int  getResult() {
    return this.result;
  }

  /**
   * 
   * @see TaskResult
   */
  public BalanceTask setResult(int result) {
    this.result = result;
    setResultIsSet(true);
    return this;
  }

  public void unsetResult() {
    __isset_bit_vector.clear(__RESULT_ISSET_ID);
  }

  // Returns true if field result is set (has been assigned a value) and false otherwise
  public boolean isSetResult() {
    return __isset_bit_vector.get(__RESULT_ISSET_ID);
  }

  public void setResultIsSet(boolean value) {
    __isset_bit_vector.set(__RESULT_ISSET_ID, value);
  }

  public void setFieldValue(int fieldID, Object value) {
    switch (fieldID) {
    case ID:
      if (value == null) {
        unsetId();
      } else {
        setId((byte[])value);
      }
      break;

    case RESULT:
      if (value == null) {
        unsetResult();
      } else {
        setResult((Integer)value);
      }
      break;

    default:
      throw new IllegalArgumentException("Field " + fieldID + " doesn't exist!");
    }
  }

  public Object getFieldValue(int fieldID) {
    switch (fieldID) {
    case ID:
      return getId();

    case RESULT:
      return getResult();

    default:
      throw new IllegalArgumentException("Field " + fieldID + " doesn't exist!");
    }
  }

  // Returns true if field corresponding to fieldID is set (has been assigned a value) and false otherwise
  public boolean isSet(int fieldID) {
    switch (fieldID) {
    case ID:
      return isSetId();
    case RESULT:
      return isSetResult();
    default:
      throw new IllegalArgumentException("Field " + fieldID + " doesn't exist!");
    }
  }

  @Override
  public boolean equals(Object that) {
    if (that == null)
      return false;
    if (that instanceof BalanceTask)
      return this.equals((BalanceTask)that);
    return false;
  }

  public boolean equals(BalanceTask that) {
    if (that == null)
      return false;
    if (this == that)
      return true;

    boolean this_present_id = true && this.isSetId();
    boolean that_present_id = true && that.isSetId();
    if (this_present_id || that_present_id) {
      if (!(this_present_id && that_present_id))
        return false;
      if (!TBaseHelper.equalsSlow(this.id, that.id))
        return false;
    }

    boolean this_present_result = true;
    boolean that_present_result = true;
    if (this_present_result || that_present_result) {
      if (!(this_present_result && that_present_result))
        return false;
      if (!TBaseHelper.equalsNobinary(this.result, that.result))
        return false;
    }

    return true;
  }

  @Override
  public int hashCode() {
    HashCodeBuilder builder = new HashCodeBuilder();

    boolean present_id = true && (isSetId());
    builder.append(present_id);
    if (present_id)
      builder.append(id);

    boolean present_result = true;
    builder.append(present_result);
    if (present_result)
      builder.append(result);

    return builder.toHashCode();
  }

  @Override
  public int compareTo(BalanceTask other) {
    if (other == null) {
      // See java.lang.Comparable docs
      throw new NullPointerException();
    }

    if (other == this) {
      return 0;
    }
    int lastComparison = 0;

    lastComparison = Boolean.valueOf(isSetId()).compareTo(other.isSetId());
    if (lastComparison != 0) {
      return lastComparison;
    }
    lastComparison = TBaseHelper.compareTo(id, other.id);
    if (lastComparison != 0) {
      return lastComparison;
    }
    lastComparison = Boolean.valueOf(isSetResult()).compareTo(other.isSetResult());
    if (lastComparison != 0) {
      return lastComparison;
    }
    lastComparison = TBaseHelper.compareTo(result, other.result);
    if (lastComparison != 0) {
      return lastComparison;
    }
    return 0;
  }

  public void read(TProtocol iprot) throws TException {
    TField field;
    iprot.readStructBegin(metaDataMap);
    while (true)
    {
      field = iprot.readFieldBegin();
      if (field.type == TType.STOP) { 
        break;
      }
      switch (field.id)
      {
        case ID:
          if (field.type == TType.STRING) {
            this.id = iprot.readBinary();
          } else { 
            TProtocolUtil.skip(iprot, field.type);
          }
          break;
        case RESULT:
          if (field.type == TType.I32) {
            this.result = iprot.readI32();
            setResultIsSet(true);
          } else { 
            TProtocolUtil.skip(iprot, field.type);
          }
          break;
        default:
          TProtocolUtil.skip(iprot, field.type);
          break;
      }
      iprot.readFieldEnd();
    }
    iprot.readStructEnd();


    // check for required fields of primitive type, which can't be checked in the validate method
    validate();
  }

  public void write(TProtocol oprot) throws TException {
    validate();

    oprot.writeStructBegin(STRUCT_DESC);
    if (this.id != null) {
      oprot.writeFieldBegin(ID_FIELD_DESC);
      oprot.writeBinary(this.id);
      oprot.writeFieldEnd();
    }
    oprot.writeFieldBegin(RESULT_FIELD_DESC);
    oprot.writeI32(this.result);
    oprot.writeFieldEnd();
    oprot.writeFieldStop();
    oprot.writeStructEnd();
  }

  @Override
  public String toString() {
    return toString(DEFAULT_PRETTY_PRINT);
  }

  @Override
  public String toString(boolean prettyPrint) {
    return toString(1, prettyPrint);
  }

  @Override
  public String toString(int indent, boolean prettyPrint) {
    String indentStr = prettyPrint ? TBaseHelper.getIndentedString(indent) : "";
    String newLine = prettyPrint ? "\n" : "";
String space = prettyPrint ? " " : "";
    StringBuilder sb = new StringBuilder("BalanceTask");
    sb.append(space);
    sb.append("(");
    sb.append(newLine);
    boolean first = true;

    sb.append(indentStr);
    sb.append("id");
    sb.append(space);
    sb.append(":").append(space);
    if (this. getId() == null) {
      sb.append("null");
    } else {
        int __id_size = Math.min(this. getId().length, 128);
        for (int i = 0; i < __id_size; i++) {
          if (i != 0) sb.append(" ");
          sb.append(Integer.toHexString(this. getId()[i]).length() > 1 ? Integer.toHexString(this. getId()[i]).substring(Integer.toHexString(this. getId()[i]).length() - 2).toUpperCase() : "0" + Integer.toHexString(this. getId()[i]).toUpperCase());
        }
        if (this. getId().length > 128) sb.append(" ...");
    }
    first = false;
    if (!first) sb.append("," + newLine);
    sb.append(indentStr);
    sb.append("result");
    sb.append(space);
    sb.append(":").append(space);
    String result_name = TaskResult.VALUES_TO_NAMES.get(this. getResult());
    if (result_name != null) {
      sb.append(result_name);
      sb.append(" (");
    }
    sb.append(this. getResult());
    if (result_name != null) {
      sb.append(")");
    }
    first = false;
    sb.append(newLine + TBaseHelper.reduceIndent(indentStr));
    sb.append(")");
    return sb.toString();
  }

  public void validate() throws TException {
    // check for required fields
    // check that fields of type enum have valid values
    if (isSetResult() && !TaskResult.VALID_VALUES.contains(result)){
      throw new TProtocolException("The field 'result' has been assigned the invalid value " + result);
    }
  }

}

