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
  public partial class ListConfigsReq : TBase
  {
    private byte[] space;
    private ConfigModule module;

    public byte[] Space
    {
      get
      {
        return space;
      }
      set
      {
        __isset.space = true;
        this.space = value;
      }
    }

    public ConfigModule Module
    {
      get
      {
        return module;
      }
      set
      {
        __isset.module = true;
        this.module = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool space;
      public bool module;
    }

    public ListConfigsReq() {
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
              this.space = iprot.ReadBinary();
              this.__isset.space = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              this.module = (ConfigModule)iprot.ReadI32();
              this.__isset.module = true;
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
      TStruct struc = new TStruct("ListConfigsReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.space != null && __isset.space) {
        field.Name = "space";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.space);
        oprot.WriteFieldEnd();
      }
      if (__isset.module) {
        field.Name = "module";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)this.module);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ListConfigsReq(");
      sb.Append("space: ");
      sb.Append(this.space);
      sb.Append(",module: ");
      sb.Append(this.module);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
