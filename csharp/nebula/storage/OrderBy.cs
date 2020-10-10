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
namespace nebula.storage
{

  [Serializable]
  public partial class OrderBy : TBase
  {
    private byte[] prop;
    private OrderDirection direction;

    public byte[] Prop
    {
      get
      {
        return prop;
      }
      set
      {
        __isset.prop = true;
        this.prop = value;
      }
    }

    public OrderDirection Direction
    {
      get
      {
        return direction;
      }
      set
      {
        __isset.direction = true;
        this.direction = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool prop;
      public bool direction;
    }

    public OrderBy() {
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
            if (field.Type == TType.String) {
              this.prop = iprot.ReadBinary();
              this.__isset.prop = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              this.direction = (OrderDirection)iprot.ReadI32();
              this.__isset.direction = true;
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
      TStruct struc = new TStruct("OrderBy");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.prop != null && __isset.prop) {
        field.Name = "prop";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.prop);
        oprot.WriteFieldEnd();
      }
      if (__isset.direction) {
        field.Name = "direction";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)this.direction);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("OrderBy(");
      sb.Append("prop: ");
      sb.Append(this.prop);
      sb.Append(",direction: ");
      sb.Append(this.direction);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
