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
namespace nebula.meta
{

  [Serializable]
  public partial class GetReq : TBase
  {
    private byte[] segment;
    private byte[] key;

    public byte[] Segment
    {
      get
      {
        return segment;
      }
      set
      {
        __isset.segment = true;
        this.segment = value;
      }
    }

    public byte[] Key
    {
      get
      {
        return key;
      }
      set
      {
        __isset.key = true;
        this.key = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool segment;
      public bool key;
    }

    public GetReq() {
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
              this.segment = iprot.ReadBinary();
              this.__isset.segment = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              this.key = iprot.ReadBinary();
              this.__isset.key = true;
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
      TStruct struc = new TStruct("GetReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.segment != null && __isset.segment) {
        field.Name = "segment";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.segment);
        oprot.WriteFieldEnd();
      }
      if (this.key != null && __isset.key) {
        field.Name = "key";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.key);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("GetReq(");
      sb.Append("segment: ");
      sb.Append(this.segment);
      sb.Append(",key: ");
      sb.Append(this.key);
      sb.Append(")");
      return sb.ToString();
    }

  }

}