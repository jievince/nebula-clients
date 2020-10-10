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
  public partial class ListPartsReq : TBase
  {
    private int space_id;
    private List<int> part_ids;

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

    public List<int> Part_ids
    {
      get
      {
        return part_ids;
      }
      set
      {
        __isset.part_ids = true;
        this.part_ids = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool space_id;
      public bool part_ids;
    }

    public ListPartsReq() {
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
                this.part_ids = new List<int>();
                TList _list74 = iprot.ReadListBegin();
                for( int _i75 = 0; _i75 < _list74.Count; ++_i75)
                {
                  int _elem76 = 0;
                  _elem76 = iprot.ReadI32();
                  this.part_ids.Add(_elem76);
                }
                iprot.ReadListEnd();
              }
              this.__isset.part_ids = true;
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
      TStruct struc = new TStruct("ListPartsReq");
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
      if (this.part_ids != null && __isset.part_ids) {
        field.Name = "part_ids";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I32, this.part_ids.Count));
          foreach (int _iter77 in this.part_ids)
          {
            oprot.WriteI32(_iter77);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ListPartsReq(");
      sb.Append("space_id: ");
      sb.Append(this.space_id);
      sb.Append(",part_ids: ");
      sb.Append(this.part_ids);
      sb.Append(")");
      return sb.ToString();
    }

  }

}