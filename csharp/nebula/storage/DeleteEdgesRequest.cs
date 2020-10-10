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
  public partial class DeleteEdgesRequest : TBase
  {
    private int space_id;
    private Dictionary<int, List<EdgeKey>> parts;

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

    public Dictionary<int, List<EdgeKey>> Parts
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

    public DeleteEdgesRequest() {
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
                this.parts = new Dictionary<int, List<EdgeKey>>();
                TMap _map130 = iprot.ReadMapBegin();
                for( int _i131 = 0; _i131 < _map130.Count; ++_i131)
                {
                  int _key132;
                  List<EdgeKey> _val133;
                  _key132 = iprot.ReadI32();
                  {
                    _val133 = new List<EdgeKey>();
                    TList _list134 = iprot.ReadListBegin();
                    for( int _i135 = 0; _i135 < _list134.Count; ++_i135)
                    {
                      EdgeKey _elem136 = new EdgeKey();
                      _elem136 = new EdgeKey();
                      _elem136.Read(iprot);
                      _val133.Add(_elem136);
                    }
                    iprot.ReadListEnd();
                  }
                  this.parts[_key132] = _val133;
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
      TStruct struc = new TStruct("DeleteEdgesRequest");
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
          foreach (int _iter137 in this.parts.Keys)
          {
            oprot.WriteI32(_iter137);
            {
              oprot.WriteListBegin(new TList(TType.Struct, this.parts[_iter137].Count));
              foreach (EdgeKey _iter138 in this.parts[_iter137])
              {
                _iter138.Write(oprot);
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
      StringBuilder sb = new StringBuilder("DeleteEdgesRequest(");
      sb.Append("space_id: ");
      sb.Append(this.space_id);
      sb.Append(",parts: ");
      sb.Append(this.parts);
      sb.Append(")");
      return sb.ToString();
    }

  }

}