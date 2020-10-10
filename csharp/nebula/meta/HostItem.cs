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
  public partial class HostItem : TBase
  {
    private nebula.HostAddr hostAddr;
    private HostStatus status;
    private Dictionary<byte[], List<int>> leader_parts;
    private Dictionary<byte[], List<int>> all_parts;
    private HostRole role;
    private byte[] git_info_sha;

    public nebula.HostAddr HostAddr
    {
      get
      {
        return hostAddr;
      }
      set
      {
        __isset.hostAddr = true;
        this.hostAddr = value;
      }
    }

    public HostStatus Status
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

    public Dictionary<byte[], List<int>> Leader_parts
    {
      get
      {
        return leader_parts;
      }
      set
      {
        __isset.leader_parts = true;
        this.leader_parts = value;
      }
    }

    public Dictionary<byte[], List<int>> All_parts
    {
      get
      {
        return all_parts;
      }
      set
      {
        __isset.all_parts = true;
        this.all_parts = value;
      }
    }

    public HostRole Role
    {
      get
      {
        return role;
      }
      set
      {
        __isset.role = true;
        this.role = value;
      }
    }

    public byte[] Git_info_sha
    {
      get
      {
        return git_info_sha;
      }
      set
      {
        __isset.git_info_sha = true;
        this.git_info_sha = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool hostAddr;
      public bool status;
      public bool leader_parts;
      public bool all_parts;
      public bool role;
      public bool git_info_sha;
    }

    public HostItem() {
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
            if (field.Type == TType.Struct) {
              this.hostAddr = new nebula.HostAddr();
              this.hostAddr.Read(iprot);
              this.__isset.hostAddr = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              this.status = (HostStatus)iprot.ReadI32();
              this.__isset.status = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Map) {
              {
                this.leader_parts = new Dictionary<byte[], List<int>>();
                TMap _map8 = iprot.ReadMapBegin();
                for( int _i9 = 0; _i9 < _map8.Count; ++_i9)
                {
                  byte[] _key10;
                  List<int> _val11;
                  _key10 = iprot.ReadBinary();
                  {
                    _val11 = new List<int>();
                    TList _list12 = iprot.ReadListBegin();
                    for( int _i13 = 0; _i13 < _list12.Count; ++_i13)
                    {
                      int _elem14 = 0;
                      _elem14 = iprot.ReadI32();
                      _val11.Add(_elem14);
                    }
                    iprot.ReadListEnd();
                  }
                  this.leader_parts[_key10] = _val11;
                }
                iprot.ReadMapEnd();
              }
              this.__isset.leader_parts = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Map) {
              {
                this.all_parts = new Dictionary<byte[], List<int>>();
                TMap _map15 = iprot.ReadMapBegin();
                for( int _i16 = 0; _i16 < _map15.Count; ++_i16)
                {
                  byte[] _key17;
                  List<int> _val18;
                  _key17 = iprot.ReadBinary();
                  {
                    _val18 = new List<int>();
                    TList _list19 = iprot.ReadListBegin();
                    for( int _i20 = 0; _i20 < _list19.Count; ++_i20)
                    {
                      int _elem21 = 0;
                      _elem21 = iprot.ReadI32();
                      _val18.Add(_elem21);
                    }
                    iprot.ReadListEnd();
                  }
                  this.all_parts[_key17] = _val18;
                }
                iprot.ReadMapEnd();
              }
              this.__isset.all_parts = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.I32) {
              this.role = (HostRole)iprot.ReadI32();
              this.__isset.role = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.String) {
              this.git_info_sha = iprot.ReadBinary();
              this.__isset.git_info_sha = true;
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
      TStruct struc = new TStruct("HostItem");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.hostAddr != null && __isset.hostAddr) {
        field.Name = "hostAddr";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        this.hostAddr.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.status) {
        field.Name = "status";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)this.status);
        oprot.WriteFieldEnd();
      }
      if (this.leader_parts != null && __isset.leader_parts) {
        field.Name = "leader_parts";
        field.Type = TType.Map;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.List, this.leader_parts.Count));
          foreach (byte[] _iter22 in this.leader_parts.Keys)
          {
            oprot.WriteBinary(_iter22);
            {
              oprot.WriteListBegin(new TList(TType.I32, this.leader_parts[_iter22].Count));
              foreach (int _iter23 in this.leader_parts[_iter22])
              {
                oprot.WriteI32(_iter23);
                oprot.WriteListEnd();
              }
            }
            oprot.WriteMapEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (this.all_parts != null && __isset.all_parts) {
        field.Name = "all_parts";
        field.Type = TType.Map;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.List, this.all_parts.Count));
          foreach (byte[] _iter24 in this.all_parts.Keys)
          {
            oprot.WriteBinary(_iter24);
            {
              oprot.WriteListBegin(new TList(TType.I32, this.all_parts[_iter24].Count));
              foreach (int _iter25 in this.all_parts[_iter24])
              {
                oprot.WriteI32(_iter25);
                oprot.WriteListEnd();
              }
            }
            oprot.WriteMapEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.role) {
        field.Name = "role";
        field.Type = TType.I32;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)this.role);
        oprot.WriteFieldEnd();
      }
      if (this.git_info_sha != null && __isset.git_info_sha) {
        field.Name = "git_info_sha";
        field.Type = TType.String;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.git_info_sha);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("HostItem(");
      sb.Append("hostAddr: ");
      sb.Append(this.hostAddr== null ? "<null>" : this.hostAddr.ToString());
      sb.Append(",status: ");
      sb.Append(this.status);
      sb.Append(",leader_parts: ");
      sb.Append(this.leader_parts);
      sb.Append(",all_parts: ");
      sb.Append(this.all_parts);
      sb.Append(",role: ");
      sb.Append(this.role);
      sb.Append(",git_info_sha: ");
      sb.Append(this.git_info_sha);
      sb.Append(")");
      return sb.ToString();
    }

  }

}