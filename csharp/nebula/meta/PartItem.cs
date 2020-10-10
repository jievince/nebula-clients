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
  public partial class PartItem : TBase
  {
    private int part_id;
    private nebula.HostAddr leader;
    private List<nebula.HostAddr> peers;
    private List<nebula.HostAddr> losts;

    public int Part_id
    {
      get
      {
        return part_id;
      }
      set
      {
        __isset.part_id = true;
        this.part_id = value;
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

    public List<nebula.HostAddr> Peers
    {
      get
      {
        return peers;
      }
      set
      {
        __isset.peers = true;
        this.peers = value;
      }
    }

    public List<nebula.HostAddr> Losts
    {
      get
      {
        return losts;
      }
      set
      {
        __isset.losts = true;
        this.losts = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool part_id;
      public bool leader;
      public bool peers;
      public bool losts;
    }

    public PartItem() {
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
              this.part_id = iprot.ReadI32();
              this.__isset.part_id = true;
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
                this.peers = new List<nebula.HostAddr>();
                TList _list66 = iprot.ReadListBegin();
                for( int _i67 = 0; _i67 < _list66.Count; ++_i67)
                {
                  nebula.HostAddr _elem68 = new nebula.HostAddr();
                  _elem68 = new nebula.HostAddr();
                  _elem68.Read(iprot);
                  this.peers.Add(_elem68);
                }
                iprot.ReadListEnd();
              }
              this.__isset.peers = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                this.losts = new List<nebula.HostAddr>();
                TList _list69 = iprot.ReadListBegin();
                for( int _i70 = 0; _i70 < _list69.Count; ++_i70)
                {
                  nebula.HostAddr _elem71 = new nebula.HostAddr();
                  _elem71 = new nebula.HostAddr();
                  _elem71.Read(iprot);
                  this.losts.Add(_elem71);
                }
                iprot.ReadListEnd();
              }
              this.__isset.losts = true;
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
      TStruct struc = new TStruct("PartItem");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.part_id) {
        field.Name = "part_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.part_id);
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
      if (this.peers != null && __isset.peers) {
        field.Name = "peers";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.peers.Count));
          foreach (nebula.HostAddr _iter72 in this.peers)
          {
            _iter72.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (this.losts != null && __isset.losts) {
        field.Name = "losts";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.losts.Count));
          foreach (nebula.HostAddr _iter73 in this.losts)
          {
            _iter73.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PartItem(");
      sb.Append("part_id: ");
      sb.Append(this.part_id);
      sb.Append(",leader: ");
      sb.Append(this.leader== null ? "<null>" : this.leader.ToString());
      sb.Append(",peers: ");
      sb.Append(this.peers);
      sb.Append(",losts: ");
      sb.Append(this.losts);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
