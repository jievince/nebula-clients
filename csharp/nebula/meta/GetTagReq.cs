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
  public partial class GetTagReq : TBase
  {
    private int space_id;
    private byte[] tag_name;
    private long version;

    public int Space_id
    {
      get
      {
        return space_id;
      }
      set
      {
        __isset.space_id = true;
        this.space_id = value;
      }
    }

    public byte[] Tag_name
    {
      get
      {
        return tag_name;
      }
      set
      {
        __isset.tag_name = true;
        this.tag_name = value;
      }
    }

    public long Version
    {
      get
      {
        return version;
      }
      set
      {
        __isset.version = true;
        this.version = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool space_id;
      public bool tag_name;
      public bool version;
    }

    public GetTagReq() {
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
              this.space_id = iprot.ReadI32();
              this.__isset.space_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              this.tag_name = iprot.ReadBinary();
              this.__isset.tag_name = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I64) {
              this.version = iprot.ReadI64();
              this.__isset.version = true;
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
      TStruct struc = new TStruct("GetTagReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.space_id) {
        field.Name = "space_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.space_id);
        oprot.WriteFieldEnd();
      }
      if (this.tag_name != null && __isset.tag_name) {
        field.Name = "tag_name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.tag_name);
        oprot.WriteFieldEnd();
      }
      if (__isset.version) {
        field.Name = "version";
        field.Type = TType.I64;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(this.version);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("GetTagReq(");
      sb.Append("space_id: ");
      sb.Append(this.space_id);
      sb.Append(",tag_name: ");
      sb.Append(this.tag_name);
      sb.Append(",version: ");
      sb.Append(this.version);
      sb.Append(")");
      return sb.ToString();
    }

  }

}