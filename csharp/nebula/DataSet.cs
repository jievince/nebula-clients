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
namespace nebula
{

  [Serializable]
  public partial class DataSet : TBase
  {
    private List<byte[]> column_names;
    private List<Row> rows;

    public List<byte[]> Column_names
    {
      get
      {
        return column_names;
      }
      set
      {
        __isset.column_names = true;
        this.column_names = value;
      }
    }

    public List<Row> Rows
    {
      get
      {
        return rows;
      }
      set
      {
        __isset.rows = true;
        this.rows = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool column_names;
      public bool rows;
    }

    public DataSet() {
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
            if (field.Type == TType.List) {
              {
                this.column_names = new List<byte[]>();
                TList _list17 = iprot.ReadListBegin();
                for( int _i18 = 0; _i18 < _list17.Count; ++_i18)
                {
                  byte[] _elem19 = null;
                  _elem19 = iprot.ReadBinary();
                  this.column_names.Add(_elem19);
                }
                iprot.ReadListEnd();
              }
              this.__isset.column_names = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                this.rows = new List<Row>();
                TList _list20 = iprot.ReadListBegin();
                for( int _i21 = 0; _i21 < _list20.Count; ++_i21)
                {
                  Row _elem22 = new Row();
                  _elem22 = new Row();
                  _elem22.Read(iprot);
                  this.rows.Add(_elem22);
                }
                iprot.ReadListEnd();
              }
              this.__isset.rows = true;
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
      TStruct struc = new TStruct("DataSet");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.column_names != null && __isset.column_names) {
        field.Name = "column_names";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, this.column_names.Count));
          foreach (byte[] _iter23 in this.column_names)
          {
            oprot.WriteBinary(_iter23);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (this.rows != null && __isset.rows) {
        field.Name = "rows";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.rows.Count));
          foreach (Row _iter24 in this.rows)
          {
            _iter24.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("DataSet(");
      sb.Append("column_names: ");
      sb.Append(this.column_names);
      sb.Append(",rows: ");
      sb.Append(this.rows);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
