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
  public partial class IndexQueryContext : TBase
  {
    private int index_id;
    private byte[] filter;
    private List<IndexColumnHint> column_hints;

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

    public byte[] Filter
    {
      get
      {
        return filter;
      }
      set
      {
        __isset.filter = true;
        this.filter = value;
      }
    }

    public List<IndexColumnHint> Column_hints
    {
      get
      {
        return column_hints;
      }
      set
      {
        __isset.column_hints = true;
        this.column_hints = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool index_id;
      public bool filter;
      public bool column_hints;
    }

    public IndexQueryContext() {
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
              this.index_id = iprot.ReadI32();
              this.__isset.index_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.String) {
              this.filter = iprot.ReadBinary();
              this.__isset.filter = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                this.column_hints = new List<IndexColumnHint>();
                TList _list155 = iprot.ReadListBegin();
                for( int _i156 = 0; _i156 < _list155.Count; ++_i156)
                {
                  IndexColumnHint _elem157 = new IndexColumnHint();
                  _elem157 = new IndexColumnHint();
                  _elem157.Read(iprot);
                  this.column_hints.Add(_elem157);
                }
                iprot.ReadListEnd();
              }
              this.__isset.column_hints = true;
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
      TStruct struc = new TStruct("IndexQueryContext");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.index_id) {
        field.Name = "index_id";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.index_id);
        oprot.WriteFieldEnd();
      }
      if (this.filter != null && __isset.filter) {
        field.Name = "filter";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.filter);
        oprot.WriteFieldEnd();
      }
      if (this.column_hints != null && __isset.column_hints) {
        field.Name = "column_hints";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.column_hints.Count));
          foreach (IndexColumnHint _iter158 in this.column_hints)
          {
            _iter158.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("IndexQueryContext(");
      sb.Append("index_id: ");
      sb.Append(this.index_id);
      sb.Append(",filter: ");
      sb.Append(this.filter);
      sb.Append(",column_hints: ");
      sb.Append(this.column_hints);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
