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
  public partial class DeleteVerticesRequest : TBase
  {
    private int space_id;
    private Dictionary<int, List<nebula.Value>> parts;

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

    public Dictionary<int, List<nebula.Value>> Parts
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


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool space_id;
      public bool parts;
    }

    public DeleteVerticesRequest() {
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
                this.parts = new Dictionary<int, List<nebula.Value>>();
                TMap _map121 = iprot.ReadMapBegin();
                for( int _i122 = 0; _i122 < _map121.Count; ++_i122)
                {
                  int _key123;
                  List<nebula.Value> _val124;
                  _key123 = iprot.ReadI32();
                  {
                    _val124 = new List<nebula.Value>();
                    TList _list125 = iprot.ReadListBegin();
                    for( int _i126 = 0; _i126 < _list125.Count; ++_i126)
                    {
                      nebula.Value _elem127 = new nebula.Value();
                      _elem127 = new nebula.Value();
                      _elem127.Read(iprot);
                      _val124.Add(_elem127);
                    }
                    iprot.ReadListEnd();
                  }
                  this.parts[_key123] = _val124;
                }
                iprot.ReadMapEnd();
              }
              this.__isset.parts = true;
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
      TStruct struc = new TStruct("DeleteVerticesRequest");
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
          foreach (int _iter128 in this.parts.Keys)
          {
            oprot.WriteI32(_iter128);
            {
              oprot.WriteListBegin(new TList(TType.Struct, this.parts[_iter128].Count));
              foreach (nebula.Value _iter129 in this.parts[_iter128])
              {
                _iter129.Write(oprot);
                oprot.WriteListEnd();
              }
            }
            oprot.WriteMapEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("DeleteVerticesRequest(");
      sb.Append("space_id: ");
      sb.Append(this.space_id);
      sb.Append(",parts: ");
      sb.Append(this.parts);
      sb.Append(")");
      return sb.ToString();
    }

  }

}