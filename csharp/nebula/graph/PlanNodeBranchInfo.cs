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
namespace nebula.graph
{

  [Serializable]
  public partial class PlanNodeBranchInfo : TBase
  {
    private bool is_do_branch;
    private long condition_node_id;

    public bool Is_do_branch
    {
      get
      {
        return is_do_branch;
      }
      set
      {
        __isset.is_do_branch = true;
        this.is_do_branch = value;
      }
    }

    public long Condition_node_id
    {
      get
      {
        return condition_node_id;
      }
      set
      {
        __isset.condition_node_id = true;
        this.condition_node_id = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool is_do_branch;
      public bool condition_node_id;
    }

    public PlanNodeBranchInfo() {
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
            if (field.Type == TType.Bool) {
              this.is_do_branch = iprot.ReadBool();
              this.__isset.is_do_branch = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I64) {
              this.condition_node_id = iprot.ReadI64();
              this.__isset.condition_node_id = true;
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
      TStruct struc = new TStruct("PlanNodeBranchInfo");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.is_do_branch) {
        field.Name = "is_do_branch";
        field.Type = TType.Bool;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(this.is_do_branch);
        oprot.WriteFieldEnd();
      }
      if (__isset.condition_node_id) {
        field.Name = "condition_node_id";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(this.condition_node_id);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlanNodeBranchInfo(");
      sb.Append("is_do_branch: ");
      sb.Append(this.is_do_branch);
      sb.Append(",condition_node_id: ");
      sb.Append(this.condition_node_id);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
