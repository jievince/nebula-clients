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
  public partial class GetEdgeIndexResp : TBase
  {
    private ErrorCode code;
    private nebula.HostAddr leader;
    private IndexItem item;

    public ErrorCode Code
    {
      get
      {
        return code;
      }
      set
      {
        __isset.code = true;
        this.code = value;
      }
    }

    public nebula.HostAddr Leader
    {
      get
      {
        return leader;
      }
      set
      {
        __isset.leader = true;
        this.leader = value;
      }
    }

    public IndexItem Item
    {
      get
      {
        return item;
      }
      set
      {
        __isset.item = true;
        this.item = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool code;
      public bool leader;
      public bool item;
    }

    public GetEdgeIndexResp() {
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
              this.code = (ErrorCode)iprot.ReadI32();
              this.__isset.code = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              this.leader = new nebula.HostAddr();
              this.leader.Read(iprot);
              this.__isset.leader = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              this.item = new IndexItem();
              this.item.Read(iprot);
              this.__isset.item = true;
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
      TStruct struc = new TStruct("GetEdgeIndexResp");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.code) {
        field.Name = "code";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)this.code);
        oprot.WriteFieldEnd();
      }
      if (this.leader != null && __isset.leader) {
        field.Name = "leader";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        this.leader.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.item != null && __isset.item) {
        field.Name = "item";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        this.item.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("GetEdgeIndexResp(");
      sb.Append("code: ");
      sb.Append(this.code);
      sb.Append(",leader: ");
      sb.Append(this.leader== null ? "<null>" : this.leader.ToString());
      sb.Append(",item: ");
      sb.Append(this.item== null ? "<null>" : this.item.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}