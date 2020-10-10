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
  public partial class AddAdminTaskRequest : TBase
  {
    private nebula.meta.AdminCmd cmd;
    private int job_id;
    private int task_id;
    private TaskPara para;
    private int concurrency;

    public nebula.meta.AdminCmd Cmd
    {
      get
      {
        return cmd;
      }
      set
      {
        __isset.cmd = true;
        this.cmd = value;
      }
    }

    public int Job_id
    {
      get
      {
        return job_id;
      }
      set
      {
        __isset.job_id = true;
        this.job_id = value;
      }
    }

    public int Task_id
    {
      get
      {
        return task_id;
      }
      set
      {
        __isset.task_id = true;
        this.task_id = value;
      }
    }

    public TaskPara Para
    {
      get
      {
        return para;
      }
      set
      {
        __isset.para = true;
        this.para = value;
      }
    }

    public int Concurrency
    {
      get
      {
        return concurrency;
      }
      set
      {
        __isset.concurrency = true;
        this.concurrency = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool cmd;
      public bool job_id;
      public bool task_id;
      public bool para;
      public bool concurrency;
    }

    public AddAdminTaskRequest() {
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
              this.cmd = (nebula.meta.AdminCmd)iprot.ReadI32();
              this.__isset.cmd = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              this.job_id = iprot.ReadI32();
              this.__isset.job_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              this.task_id = iprot.ReadI32();
              this.__isset.task_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Struct) {
              this.para = new TaskPara();
              this.para.Read(iprot);
              this.__isset.para = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              this.concurrency = iprot.ReadI32();
              this.__isset.concurrency = true;
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
      TStruct struc = new TStruct("AddAdminTaskRequest");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.cmd) {
        field.Name = "cmd";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)this.cmd);
        oprot.WriteFieldEnd();
      }
      if (__isset.job_id) {
        field.Name = "job_id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.job_id);
        oprot.WriteFieldEnd();
      }
      if (__isset.task_id) {
        field.Name = "task_id";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.task_id);
        oprot.WriteFieldEnd();
      }
      if (this.para != null && __isset.para) {
        field.Name = "para";
        field.Type = TType.Struct;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        this.para.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.concurrency) {
        field.Name = "concurrency";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.concurrency);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("AddAdminTaskRequest(");
      sb.Append("cmd: ");
      sb.Append(this.cmd);
      sb.Append(",job_id: ");
      sb.Append(this.job_id);
      sb.Append(",task_id: ");
      sb.Append(this.task_id);
      sb.Append(",para: ");
      sb.Append(this.para== null ? "<null>" : this.para.ToString());
      sb.Append(",concurrency: ");
      sb.Append(this.concurrency);
      sb.Append(")");
      return sb.ToString();
    }

  }

}