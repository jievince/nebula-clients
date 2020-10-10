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
  public partial class RebuildIndexRequest : TBase
  {
    private int space_id;
    private List<int> parts;
    private int index_id;

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

    public List<int> Parts
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

    public int Index_id
    {
      get
      {
        return index_id;
      }
      set
      {
        __isset.index_id = true;
        this.index_id = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool space_id;
      public bool parts;
      public bool index_id;
    }

    public RebuildIndexRequest() {
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
            if (field.Type == TType.List) {
              {
                this.parts = new List<int>();
                TList _list204 = iprot.ReadListBegin();
                for( int _i205 = 0; _i205 < _list204.Count; ++_i205)
                {
                  int _elem206 = 0;
                  _elem206 = iprot.ReadI32();
                  this.parts.Add(_elem206);
                }
                iprot.ReadListEnd();
              }
              this.__isset.parts = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.I32) {
              this.index_id = iprot.ReadI32();
              this.__isset.index_id = true;
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
      TStruct struc = new TStruct("RebuildIndexRequest");
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
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I32, this.parts.Count));
          foreach (int _iter207 in this.parts)
          {
            oprot.WriteI32(_iter207);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.index_id) {
        field.Name = "index_id";
        field.Type = TType.I32;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.index_id);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("RebuildIndexRequest(");
      sb.Append("space_id: ");
      sb.Append(this.space_id);
      sb.Append(",parts: ");
      sb.Append(this.parts);
      sb.Append(",index_id: ");
      sb.Append(this.index_id);
      sb.Append(")");
      return sb.ToString();
    }

  }

}