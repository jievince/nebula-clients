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
  public partial class IndexStatus : TBase
  {
    private byte[] name;
    private byte[] status;

    public byte[] Name
    {
      get
      {
        return name;
      }
      set
      {
        __isset.name = true;
        this.name = value;
      }
    }

    public byte[] Status
    {
      get
      {
        return status;
      }
      set
      {
        __isset.status = true;
        this.status = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool name;
      public bool status;
    }

    public IndexStatus() {
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
              this.name = iprot.ReadBinary();
              this.__isset.name = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              this.status = iprot.ReadBinary();
              this.__isset.status = true;
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
      TStruct struc = new TStruct("IndexStatus");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.name);
        oprot.WriteFieldEnd();
      }
      if (this.status != null && __isset.status) {
        field.Name = "status";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.status);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("IndexStatus(");
      sb.Append("name: ");
      sb.Append(this.name);
      sb.Append(",status: ");
      sb.Append(this.status);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
