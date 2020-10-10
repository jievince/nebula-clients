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
  public partial class AppendLogResponse : TBase
  {
    private ErrorCode error_code;
    private long current_term;
    private string leader_addr;
    private int leader_port;
    private long committed_log_id;
    private long last_log_id;
    private long last_log_term;

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

    public long Current_term
    {
      get
      {
        return current_term;
      }
      set
      {
        __isset.current_term = true;
        this.current_term = value;
      }
    }

    public string Leader_addr
    {
      get
      {
        return leader_addr;
      }
      set
      {
        __isset.leader_addr = true;
        this.leader_addr = value;
      }
    }

    public int Leader_port
    {
      get
      {
        return leader_port;
      }
      set
      {
        __isset.leader_port = true;
        this.leader_port = value;
      }
    }

    public long Committed_log_id
    {
      get
      {
        return committed_log_id;
      }
      set
      {
        __isset.committed_log_id = true;
        this.committed_log_id = value;
      }
    }

    public long Last_log_id
    {
      get
      {
        return last_log_id;
      }
      set
      {
        __isset.last_log_id = true;
        this.last_log_id = value;
      }
    }

    public long Last_log_term
    {
      get
      {
        return last_log_term;
      }
      set
      {
        __isset.last_log_term = true;
        this.last_log_term = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool error_code;
      public bool current_term;
      public bool leader_addr;
      public bool leader_port;
      public bool committed_log_id;
      public bool last_log_id;
      public bool last_log_term;
    }

    public AppendLogResponse() {
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
          case 2:
            if (field.Type == TType.I64) {
              this.current_term = iprot.ReadI64();
              this.__isset.current_term = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              this.leader_addr = iprot.ReadString();
              this.__isset.leader_addr = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              this.leader_port = iprot.ReadI32();
              this.__isset.leader_port = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I64) {
              this.committed_log_id = iprot.ReadI64();
              this.__isset.committed_log_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I64) {
              this.last_log_id = iprot.ReadI64();
              this.__isset.last_log_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I64) {
              this.last_log_term = iprot.ReadI64();
              this.__isset.last_log_term = true;
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
      TStruct struc = new TStruct("AppendLogResponse");
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
      if (__isset.current_term) {
        field.Name = "current_term";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(this.current_term);
        oprot.WriteFieldEnd();
      }
      if (this.leader_addr != null && __isset.leader_addr) {
        field.Name = "leader_addr";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteString(this.leader_addr);
        oprot.WriteFieldEnd();
      }
      if (__isset.leader_port) {
        field.Name = "leader_port";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.leader_port);
        oprot.WriteFieldEnd();
      }
      if (__isset.committed_log_id) {
        field.Name = "committed_log_id";
        field.Type = TType.I64;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(this.committed_log_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.last_log_id) {
        field.Name = "last_log_id";
        field.Type = TType.I64;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(this.last_log_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.last_log_term) {
        field.Name = "last_log_term";
        field.Type = TType.I64;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(this.last_log_term);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("AppendLogResponse(");
      sb.Append("error_code: ");
      sb.Append(this.error_code);
      sb.Append(",current_term: ");
      sb.Append(this.current_term);
      sb.Append(",leader_addr: ");
      sb.Append(this.leader_addr);
      sb.Append(",leader_port: ");
      sb.Append(this.leader_port);
      sb.Append(",committed_log_id: ");
      sb.Append(this.committed_log_id);
      sb.Append(",last_log_id: ");
      sb.Append(this.last_log_id);
      sb.Append(",last_log_term: ");
      sb.Append(this.last_log_term);
      sb.Append(")");
      return sb.ToString();
    }

  }

}