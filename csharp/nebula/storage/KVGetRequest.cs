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
  public partial class KVGetRequest : TBase
  {
    private int space_id;
    private Dictionary<int, List<byte[]>> parts;
    private bool return_partly;

    public int Space_id
    {
      get
      {
        return space_id;
      }
      set
      {
        __isset.space_id = true;
        this.space_id = value;
      }
    }

    public Dictionary<int, List<byte[]>> Parts
    {
      get
      {
        return parts;
      }
      set
      {
        __isset.parts = true;
        this.parts = value;
      }
    }

    public bool Return_partly
    {
      get
      {
        return return_partly;
      }
      set
      {
        __isset.return_partly = true;
        this.return_partly = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool space_id;
      public bool parts;
      public bool return_partly;
    }

    public KVGetRequest() {
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
              this.space_id = iprot.ReadI32();
              this.__isset.space_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Map) {
              {
                this.parts = new Dictionary<int, List<byte[]>>();
                TMap _map208 = iprot.ReadMapBegin();
                for( int _i209 = 0; _i209 < _map208.Count; ++_i209)
                {
                  int _key210;
                  List<byte[]> _val211;
                  _key210 = iprot.ReadI32();
                  {
                    _val211 = new List<byte[]>();
                    TList _list212 = iprot.ReadListBegin();
                    for( int _i213 = 0; _i213 < _list212.Count; ++_i213)
                    {
                      byte[] _elem214 = null;
                      _elem214 = iprot.ReadBinary();
                      _val211.Add(_elem214);
                    }
                    iprot.ReadListEnd();
                  }
                  this.parts[_key210] = _val211;
                }
                iprot.ReadMapEnd();
              }
              this.__isset.parts = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Bool) {
              this.return_partly = iprot.ReadBool();
              this.__isset.return_partly = true;
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
      TStruct struc = new TStruct("KVGetRequest");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.space_id) {
        field.Name = "space_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.space_id);
        oprot.WriteFieldEnd();
      }
      if (this.parts != null && __isset.parts) {
        field.Name = "parts";
        field.Type = TType.Map;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.I32, TType.List, this.parts.Count));
          foreach (int _iter215 in this.parts.Keys)
          {
            oprot.WriteI32(_iter215);
            {
              oprot.WriteListBegin(new TList(TType.String, this.parts[_iter215].Count));
              foreach (byte[] _iter216 in this.parts[_iter215])
              {
                oprot.WriteBinary(_iter216);
                oprot.WriteListEnd();
              }
            }
            oprot.WriteMapEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.return_partly) {
        field.Name = "return_partly";
        field.Type = TType.Bool;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(this.return_partly);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("KVGetRequest(");
      sb.Append("space_id: ");
      sb.Append(this.space_id);
      sb.Append(",parts: ");
      sb.Append(this.parts);
      sb.Append(",return_partly: ");
      sb.Append(this.return_partly);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
