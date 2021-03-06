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
  public partial class AlterTagReq : TBase
  {
    private int space_id;
    private byte[] tag_name;
    private List<AlterSchemaItem> tag_items;
    private SchemaProp schema_prop;

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

    public byte[] Tag_name
    {
      get
      {
        return tag_name;
      }
      set
      {
        __isset.tag_name = true;
        this.tag_name = value;
      }
    }

    public List<AlterSchemaItem> Tag_items
    {
      get
      {
        return tag_items;
      }
      set
      {
        __isset.tag_items = true;
        this.tag_items = value;
      }
    }

    public SchemaProp Schema_prop
    {
      get
      {
        return schema_prop;
      }
      set
      {
        __isset.schema_prop = true;
        this.schema_prop = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool space_id;
      public bool tag_name;
      public bool tag_items;
      public bool schema_prop;
    }

    public AlterTagReq() {
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
            if (field.Type == TType.String) {
              this.tag_name = iprot.ReadBinary();
              this.__isset.tag_name = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                this.tag_items = new List<AlterSchemaItem>();
                TList _list46 = iprot.ReadListBegin();
                for( int _i47 = 0; _i47 < _list46.Count; ++_i47)
                {
                  AlterSchemaItem _elem48 = new AlterSchemaItem();
                  _elem48 = new AlterSchemaItem();
                  _elem48.Read(iprot);
                  this.tag_items.Add(_elem48);
                }
                iprot.ReadListEnd();
              }
              this.__isset.tag_items = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.Struct) {
              this.schema_prop = new SchemaProp();
              this.schema_prop.Read(iprot);
              this.__isset.schema_prop = true;
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
      TStruct struc = new TStruct("AlterTagReq");
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
      if (this.tag_name != null && __isset.tag_name) {
        field.Name = "tag_name";
        field.Type = TType.String;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.tag_name);
        oprot.WriteFieldEnd();
      }
      if (this.tag_items != null && __isset.tag_items) {
        field.Name = "tag_items";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.tag_items.Count));
          foreach (AlterSchemaItem _iter49 in this.tag_items)
          {
            _iter49.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (this.schema_prop != null && __isset.schema_prop) {
        field.Name = "schema_prop";
        field.Type = TType.Struct;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        this.schema_prop.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("AlterTagReq(");
      sb.Append("space_id: ");
      sb.Append(this.space_id);
      sb.Append(",tag_name: ");
      sb.Append(this.tag_name);
      sb.Append(",tag_items: ");
      sb.Append(this.tag_items);
      sb.Append(",schema_prop: ");
      sb.Append(this.schema_prop== null ? "<null>" : this.schema_prop.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
