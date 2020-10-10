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
  public partial class HostAddr : TBase
  {
    private string host;
    private int port;

    public string Host
    {
      get
      {
        return host;
      }
      set
      {
        __isset.host = true;
        this.host = value;
      }
    }

    public int Port
    {
      get
      {
        return port;
      }
      set
      {
        __isset.port = true;
        this.port = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool host;
      public bool port;
    }

    public HostAddr() {
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
              this.host = iprot.ReadString();
              this.__isset.host = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              this.port = iprot.ReadI32();
              this.__isset.port = true;
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
      TStruct struc = new TStruct("HostAddr");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.host != null && __isset.host) {
        field.Name = "host";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.host);
        oprot.WriteFieldEnd();
      }
      if (__isset.port) {
        field.Name = "port";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.port);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("HostAddr(");
      sb.Append("host: ");
      sb.Append(this.host);
      sb.Append(",port: ");
      sb.Append(this.port);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
