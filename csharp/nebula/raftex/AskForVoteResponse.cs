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
namespace nebula.raftex
{

  [Serializable]
  public partial class AskForVoteResponse : TBase
  {
    private ErrorCode error_code;

    public ErrorCode Error_code
    {
      get
      {
        return error_code;
      }
      set
      {
        __isset.error_code = true;
        this.error_code = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool error_code;
    }

    public AskForVoteResponse() {
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
              this.error_code = (ErrorCode)iprot.ReadI32();
              this.__isset.error_code = true;
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
      TStruct struc = new TStruct("AskForVoteResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.error_code) {
        field.Name = "error_code";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)this.error_code);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("AskForVoteResponse(");
      sb.Append("error_code: ");
      sb.Append(this.error_code);
      sb.Append(")");
      return sb.ToString();
    }

  }

}