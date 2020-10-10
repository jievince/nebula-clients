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
  public partial class IndexItem : TBase
  {
    private int index_id;
    private byte[] index_name;
    private SchemaID schema_id;
    private byte[] schema_name;
    private List<ColumnDef> fields;

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

    public byte[] Index_name
    {
      get
      {
        return index_name;
      }
      set
      {
        __isset.index_name = true;
        this.index_name = value;
      }
    }

    public SchemaID Schema_id
    {
      get
      {
        return schema_id;
      }
      set
      {
        __isset.schema_id = true;
        this.schema_id = value;
      }
    }

    public byte[] Schema_name
    {
      get
      {
        return schema_name;
      }
      set
      {
        __isset.schema_name = true;
        this.schema_name = value;
      }
    }

    public List<ColumnDef> Fields
    {
      get
      {
        return fields;
      }
      set
      {
        __isset.fields = true;
        this.fields = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool index_id;
      public bool index_name;
      public bool schema_id;
      public bool schema_name;
      public bool fields;
    }

    public IndexItem() {
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
              this.index_name = iprot.ReadBinary();
              this.__isset.index_name = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              this.schema_id = new SchemaID();
              this.schema_id.Read(iprot);
              this.__isset.schema_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.String) {
              this.schema_name = iprot.ReadBinary();
              this.__isset.schema_name = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                this.fields = new List<ColumnDef>();
                TList _list4 = iprot.ReadListBegin();
                for( int _i5 = 0; _i5 < _list4.Count; ++_i5)
                {
                  ColumnDef _elem6 = new ColumnDef();
                  _elem6 = new ColumnDef();
                  _elem6.Read(iprot);
                  this.fields.Add(_elem6);
                }
                iprot.ReadListEnd();
              }
              this.__isset.fields = true;
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
      TStruct struc = new TStruct("IndexItem");
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
      if (this.index_name != null && __isset.index_name) {
        field.Name = "index_name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.index_name);
        oprot.WriteFieldEnd();
      }
      if (this.schema_id != null && __isset.schema_id) {
        field.Name = "schema_id";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        this.schema_id.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.schema_name != null && __isset.schema_name) {
        field.Name = "schema_name";
        field.Type = TType.String;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.schema_name);
        oprot.WriteFieldEnd();
      }
      if (this.fields != null && __isset.fields) {
        field.Name = "fields";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.fields.Count));
          foreach (ColumnDef _iter7 in this.fields)
          {
            _iter7.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("IndexItem(");
      sb.Append("index_id: ");
      sb.Append(this.index_id);
      sb.Append(",index_name: ");
      sb.Append(this.index_name);
      sb.Append(",schema_id: ");
      sb.Append(this.schema_id== null ? "<null>" : this.schema_id.ToString());
      sb.Append(",schema_name: ");
      sb.Append(this.schema_name);
      sb.Append(",fields: ");
      sb.Append(this.fields);
      sb.Append(")");
      return sb.ToString();
    }

  }

}