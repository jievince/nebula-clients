/**
 * Autogenerated by Thrift
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using Thrift.Protocol;
using Thrift.Transport;
namespace nebula
{

  [Serializable]
  public partial class Value : TBase
  {
    private NullType nVal;
    private bool bVal;
    private long iVal;
    private double fVal;
    private byte[] sVal;
    private Date dVal;
    private Time tVal;
    private DateTime dtVal;
    private Vertex vVal;
    private Edge eVal;
    private Path pVal;
    private List lVal;
    private Map mVal;
    private Set uVal;
    private DataSet gVal;

    public NullType NVal
    {
      get
      {
        return nVal;
      }
      set
      {
        __isset.nVal = true;
        this.nVal = value;
      }
    }

    public bool BVal
    {
      get
      {
        return bVal;
      }
      set
      {
        __isset.bVal = true;
        this.bVal = value;
      }
    }

    public long IVal
    {
      get
      {
        return iVal;
      }
      set
      {
        __isset.iVal = true;
        this.iVal = value;
      }
    }

    public double FVal
    {
      get
      {
        return fVal;
      }
      set
      {
        __isset.fVal = true;
        this.fVal = value;
      }
    }

    public byte[] SVal
    {
      get
      {
        return sVal;
      }
      set
      {
        __isset.sVal = true;
        this.sVal = value;
      }
    }

    public Date DVal
    {
      get
      {
        return dVal;
      }
      set
      {
        __isset.dVal = true;
        this.dVal = value;
      }
    }

    public Time TVal
    {
      get
      {
        return tVal;
      }
      set
      {
        __isset.tVal = true;
        this.tVal = value;
      }
    }

    public DateTime DtVal
    {
      get
      {
        return dtVal;
      }
      set
      {
        __isset.dtVal = true;
        this.dtVal = value;
      }
    }

    public Vertex VVal
    {
      get
      {
        return vVal;
      }
      set
      {
        __isset.vVal = true;
        this.vVal = value;
      }
    }

    public Edge EVal
    {
      get
      {
        return eVal;
      }
      set
      {
        __isset.eVal = true;
        this.eVal = value;
      }
    }

    public Path PVal
    {
      get
      {
        return pVal;
      }
      set
      {
        __isset.pVal = true;
        this.pVal = value;
      }
    }

    public List LVal
    {
      get
      {
        return lVal;
      }
      set
      {
        __isset.lVal = true;
        this.lVal = value;
      }
    }

    public Map MVal
    {
      get
      {
        return mVal;
      }
      set
      {
        __isset.mVal = true;
        this.mVal = value;
      }
    }

    public Set UVal
    {
      get
      {
        return uVal;
      }
      set
      {
        __isset.uVal = true;
        this.uVal = value;
      }
    }

    public DataSet GVal
    {
      get
      {
        return gVal;
      }
      set
      {
        __isset.gVal = true;
        this.gVal = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool nVal;
      public bool bVal;
      public bool iVal;
      public bool fVal;
      public bool sVal;
      public bool dVal;
      public bool tVal;
      public bool dtVal;
      public bool vVal;
      public bool eVal;
      public bool pVal;
      public bool lVal;
      public bool mVal;
      public bool uVal;
      public bool gVal;
    }

    public Value() {
    }

    public void Read (TProtocol iprot)
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.I32) {
              this.nVal = (NullType)iprot.ReadI32();
              this.__isset.nVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Bool) {
              this.bVal = iprot.ReadBool();
              this.__isset.bVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I64) {
              this.iVal = iprot.ReadI64();
              this.__isset.iVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Double) {
              this.fVal = iprot.ReadDouble();
              this.__isset.fVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.String) {
              this.sVal = iprot.ReadBinary();
              this.__isset.sVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Struct) {
              this.dVal = new Date();
              this.dVal.Read(iprot);
              this.__isset.dVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.Struct) {
              this.tVal = new Time();
              this.tVal.Read(iprot);
              this.__isset.tVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.Struct) {
              this.dtVal = new DateTime();
              this.dtVal.Read(iprot);
              this.__isset.dtVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 9:
            if (field.Type == TType.Struct) {
              this.vVal = new Vertex();
              this.vVal.Read(iprot);
              this.__isset.vVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 10:
            if (field.Type == TType.Struct) {
              this.eVal = new Edge();
              this.eVal.Read(iprot);
              this.__isset.eVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 11:
            if (field.Type == TType.Struct) {
              this.pVal = new Path();
              this.pVal.Read(iprot);
              this.__isset.pVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 12:
            if (field.Type == TType.Struct) {
              this.lVal = new List();
              this.lVal.Read(iprot);
              this.__isset.lVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 13:
            if (field.Type == TType.Struct) {
              this.mVal = new Map();
              this.mVal.Read(iprot);
              this.__isset.mVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 14:
            if (field.Type == TType.Struct) {
              this.uVal = new Set();
              this.uVal.Read(iprot);
              this.__isset.uVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 15:
            if (field.Type == TType.Struct) {
              this.gVal = new DataSet();
              this.gVal.Read(iprot);
              this.__isset.gVal = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }

    public void Write(TProtocol oprot) {
      TStruct struc = new TStruct("Value");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.nVal) {
        field.Name = "nVal";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)this.nVal);
        oprot.WriteFieldEnd();
      }
      if (__isset.bVal) {
        field.Name = "bVal";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(this.bVal);
        oprot.WriteFieldEnd();
      }
      if (__isset.iVal) {
        field.Name = "iVal";
        field.Type = TType.I64;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(this.iVal);
        oprot.WriteFieldEnd();
      }
      if (__isset.fVal) {
        field.Name = "fVal";
        field.Type = TType.Double;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteDouble(this.fVal);
        oprot.WriteFieldEnd();
      }
      if (this.sVal != null && __isset.sVal) {
        field.Name = "sVal";
        field.Type = TType.String;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.sVal);
        oprot.WriteFieldEnd();
      }
      if (this.dVal != null && __isset.dVal) {
        field.Name = "dVal";
        field.Type = TType.Struct;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        this.dVal.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.tVal != null && __isset.tVal) {
        field.Name = "tVal";
        field.Type = TType.Struct;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        this.tVal.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.dtVal != null && __isset.dtVal) {
        field.Name = "dtVal";
        field.Type = TType.Struct;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        this.dtVal.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.vVal != null && __isset.vVal) {
        field.Name = "vVal";
        field.Type = TType.Struct;
        field.ID = 9;
        oprot.WriteFieldBegin(field);
        this.vVal.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.eVal != null && __isset.eVal) {
        field.Name = "eVal";
        field.Type = TType.Struct;
        field.ID = 10;
        oprot.WriteFieldBegin(field);
        this.eVal.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.pVal != null && __isset.pVal) {
        field.Name = "pVal";
        field.Type = TType.Struct;
        field.ID = 11;
        oprot.WriteFieldBegin(field);
        this.pVal.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.lVal != null && __isset.lVal) {
        field.Name = "lVal";
        field.Type = TType.Struct;
        field.ID = 12;
        oprot.WriteFieldBegin(field);
        this.lVal.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.mVal != null && __isset.mVal) {
        field.Name = "mVal";
        field.Type = TType.Struct;
        field.ID = 13;
        oprot.WriteFieldBegin(field);
        this.mVal.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.uVal != null && __isset.uVal) {
        field.Name = "uVal";
        field.Type = TType.Struct;
        field.ID = 14;
        oprot.WriteFieldBegin(field);
        this.uVal.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.gVal != null && __isset.gVal) {
        field.Name = "gVal";
        field.Type = TType.Struct;
        field.ID = 15;
        oprot.WriteFieldBegin(field);
        this.gVal.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Value(");
      sb.Append("nVal: ");
      sb.Append(this.nVal);
      sb.Append(",bVal: ");
      sb.Append(this.bVal);
      sb.Append(",iVal: ");
      sb.Append(this.iVal);
      sb.Append(",fVal: ");
      sb.Append(this.fVal);
      sb.Append(",sVal: ");
      sb.Append(this.sVal);
      sb.Append(",dVal: ");
      sb.Append(this.dVal== null ? "<null>" : this.dVal.ToString());
      sb.Append(",tVal: ");
      sb.Append(this.tVal== null ? "<null>" : this.tVal.ToString());
      sb.Append(",dtVal: ");
      sb.Append(this.dtVal== null ? "<null>" : this.dtVal.ToString());
      sb.Append(",vVal: ");
      sb.Append(this.vVal);
      sb.Append(",eVal: ");
      sb.Append(this.eVal);
      sb.Append(",pVal: ");
      sb.Append(this.pVal);
      sb.Append(",lVal: ");
      sb.Append(this.lVal);
      sb.Append(",mVal: ");
      sb.Append(this.mVal);
      sb.Append(",uVal: ");
      sb.Append(this.uVal);
      sb.Append(",gVal: ");
      sb.Append(this.gVal);
      sb.Append(")");
      return sb.ToString();
    }

  }

}