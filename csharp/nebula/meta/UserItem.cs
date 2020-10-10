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
  public partial class UserItem : TBase
  {
    private byte[] account;
    private bool is_lock;
    private int max_queries_per_hour;
    private int max_updates_per_hour;
    private int max_connections_per_hour;
    private int max_user_connections;

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

    public bool Is_lock
    {
      get
      {
        return is_lock;
      }
      set
      {
        __isset.is_lock = true;
        this.is_lock = value;
      }
    }

    public int Max_queries_per_hour
    {
      get
      {
        return max_queries_per_hour;
      }
      set
      {
        __isset.max_queries_per_hour = true;
        this.max_queries_per_hour = value;
      }
    }

    public int Max_updates_per_hour
    {
      get
      {
        return max_updates_per_hour;
      }
      set
      {
        __isset.max_updates_per_hour = true;
        this.max_updates_per_hour = value;
      }
    }

    public int Max_connections_per_hour
    {
      get
      {
        return max_connections_per_hour;
      }
      set
      {
        __isset.max_connections_per_hour = true;
        this.max_connections_per_hour = value;
      }
    }

    public int Max_user_connections
    {
      get
      {
        return max_user_connections;
      }
      set
      {
        __isset.max_user_connections = true;
        this.max_user_connections = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool account;
      public bool is_lock;
      public bool max_queries_per_hour;
      public bool max_updates_per_hour;
      public bool max_connections_per_hour;
      public bool max_user_connections;
    }

    public UserItem() {
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
            if (field.Type == TType.Bool) {
              this.is_lock = iprot.ReadBool();
              this.__isset.is_lock = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              this.max_queries_per_hour = iprot.ReadI32();
              this.__isset.max_queries_per_hour = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.I32) {
              this.max_updates_per_hour = iprot.ReadI32();
              this.__isset.max_updates_per_hour = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              this.max_connections_per_hour = iprot.ReadI32();
              this.__isset.max_connections_per_hour = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              this.max_user_connections = iprot.ReadI32();
              this.__isset.max_user_connections = true;
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
      TStruct struc = new TStruct("UserItem");
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
      if (__isset.is_lock) {
        field.Name = "is_lock";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(this.is_lock);
        oprot.WriteFieldEnd();
      }
      if (__isset.max_queries_per_hour) {
        field.Name = "max_queries_per_hour";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.max_queries_per_hour);
        oprot.WriteFieldEnd();
      }
      if (__isset.max_updates_per_hour) {
        field.Name = "max_updates_per_hour";
        field.Type = TType.I32;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.max_updates_per_hour);
        oprot.WriteFieldEnd();
      }
      if (__isset.max_connections_per_hour) {
        field.Name = "max_connections_per_hour";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.max_connections_per_hour);
        oprot.WriteFieldEnd();
      }
      if (__isset.max_user_connections) {
        field.Name = "max_user_connections";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.max_user_connections);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("UserItem(");
      sb.Append("account: ");
      sb.Append(this.account);
      sb.Append(",is_lock: ");
      sb.Append(this.is_lock);
      sb.Append(",max_queries_per_hour: ");
      sb.Append(this.max_queries_per_hour);
      sb.Append(",max_updates_per_hour: ");
      sb.Append(this.max_updates_per_hour);
      sb.Append(",max_connections_per_hour: ");
      sb.Append(this.max_connections_per_hour);
      sb.Append(",max_user_connections: ");
      sb.Append(this.max_user_connections);
      sb.Append(")");
      return sb.ToString();
    }

  }

}