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
  public partial class ListConfigsResp : TBase
  {
    private ErrorCode code;
    private nebula.HostAddr leader;
    private List<ConfigItem> items;

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

    public List<ConfigItem> Items
    {
      get
      {
        return items;
      }
      set
      {
        __isset.items = true;
        this.items = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool code;
      public bool leader;
      public bool items;
    }

    public ListConfigsResp() {
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
            if (field.Type == TType.List) {
              {
                this.items = new List<ConfigItem>();
                TList _list157 = iprot.ReadListBegin();
                for( int _i158 = 0; _i158 < _list157.Count; ++_i158)
                {
                  ConfigItem _elem159 = new ConfigItem();
                  _elem159 = new ConfigItem();
                  _elem159.Read(iprot);
                  this.items.Add(_elem159);
                }
                iprot.ReadListEnd();
              }
              this.__isset.items = true;
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
      TStruct struc = new TStruct("ListConfigsResp");
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
      if (this.items != null && __isset.items) {
        field.Name = "items";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.items.Count));
          foreach (ConfigItem _iter160 in this.items)
          {
            _iter160.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ListConfigsResp(");
      sb.Append("code: ");
      sb.Append(this.code);
      sb.Append(",leader: ");
      sb.Append(this.leader== null ? "<null>" : this.leader.ToString());
      sb.Append(",items: ");
      sb.Append(this.items);
      sb.Append(")");
      return sb.ToString();
    }

  }

}