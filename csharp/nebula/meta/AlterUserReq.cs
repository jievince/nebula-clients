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
  public partial class AlterUserReq : TBase
  {
    private byte[] account;
    private byte[] encoded_pwd;

    public byte[] Account
    {
      get
      {
        return account;
      }
      set
      {
        __isset.account = true;
        this.account = value;
      }
    }

    public byte[] Encoded_pwd
    {
      get
      {
        return encoded_pwd;
      }
      set
      {
        __isset.encoded_pwd = true;
        this.encoded_pwd = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool account;
      public bool encoded_pwd;
    }

    public AlterUserReq() {
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
              this.account = iprot.ReadBinary();
              this.__isset.account = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              this.encoded_pwd = iprot.ReadBinary();
              this.__isset.encoded_pwd = true;
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
      TStruct struc = new TStruct("AlterUserReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.account != null && __isset.account) {
        field.Name = "account";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.account);
        oprot.WriteFieldEnd();
      }
      if (this.encoded_pwd != null && __isset.encoded_pwd) {
        field.Name = "encoded_pwd";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.encoded_pwd);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("AlterUserReq(");
      sb.Append("account: ");
      sb.Append(this.account);
      sb.Append(",encoded_pwd: ");
      sb.Append(this.encoded_pwd);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
