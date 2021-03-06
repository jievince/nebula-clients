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
  public partial class UpdateEdgeRequest : TBase
  {
    private int space_id;
    private int part_id;
    private EdgeKey edge_key;
    private List<UpdatedProp> updated_props;
    private bool insertable;
    private List<byte[]> return_props;
    private byte[] condition;

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

    public EdgeKey Edge_key
    {
      get
      {
        return edge_key;
      }
      set
      {
        __isset.edge_key = true;
        this.edge_key = value;
      }
    }

    public List<UpdatedProp> Updated_props
    {
      get
      {
        return updated_props;
      }
      set
      {
        __isset.updated_props = true;
        this.updated_props = value;
      }
    }

    public bool Insertable
    {
      get
      {
        return insertable;
      }
      set
      {
        __isset.insertable = true;
        this.insertable = value;
      }
    }

    public List<byte[]> Return_props
    {
      get
      {
        return return_props;
      }
      set
      {
        __isset.return_props = true;
        this.return_props = value;
      }
    }

    public byte[] Condition
    {
      get
      {
        return condition;
      }
      set
      {
        __isset.condition = true;
        this.condition = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool space_id;
      public bool part_id;
      public bool edge_key;
      public bool updated_props;
      public bool insertable;
      public bool return_props;
      public bool condition;
    }

    public UpdateEdgeRequest() {
      this.insertable = false;
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
            if (field.Type == TType.I32) {
              this.part_id = iprot.ReadI32();
              this.__isset.part_id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Struct) {
              this.edge_key = new EdgeKey();
              this.edge_key.Read(iprot);
              this.__isset.edge_key = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                this.updated_props = new List<UpdatedProp>();
                TList _list147 = iprot.ReadListBegin();
                for( int _i148 = 0; _i148 < _list147.Count; ++_i148)
                {
                  UpdatedProp _elem149 = new UpdatedProp();
                  _elem149 = new UpdatedProp();
                  _elem149.Read(iprot);
                  this.updated_props.Add(_elem149);
                }
                iprot.ReadListEnd();
              }
              this.__isset.updated_props = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Bool) {
              this.insertable = iprot.ReadBool();
              this.__isset.insertable = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.List) {
              {
                this.return_props = new List<byte[]>();
                TList _list150 = iprot.ReadListBegin();
                for( int _i151 = 0; _i151 < _list150.Count; ++_i151)
                {
                  byte[] _elem152 = null;
                  _elem152 = iprot.ReadBinary();
                  this.return_props.Add(_elem152);
                }
                iprot.ReadListEnd();
              }
              this.__isset.return_props = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.String) {
              this.condition = iprot.ReadBinary();
              this.__isset.condition = true;
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
      TStruct struc = new TStruct("UpdateEdgeRequest");
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
      if (__isset.part_id) {
        field.Name = "part_id";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.part_id);
        oprot.WriteFieldEnd();
      }
      if (this.edge_key != null && __isset.edge_key) {
        field.Name = "edge_key";
        field.Type = TType.Struct;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        this.edge_key.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.updated_props != null && __isset.updated_props) {
        field.Name = "updated_props";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.updated_props.Count));
          foreach (UpdatedProp _iter153 in this.updated_props)
          {
            _iter153.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.insertable) {
        field.Name = "insertable";
        field.Type = TType.Bool;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(this.insertable);
        oprot.WriteFieldEnd();
      }
      if (this.return_props != null && __isset.return_props) {
        field.Name = "return_props";
        field.Type = TType.List;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, this.return_props.Count));
          foreach (byte[] _iter154 in this.return_props)
          {
            oprot.WriteBinary(_iter154);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (this.condition != null && __isset.condition) {
        field.Name = "condition";
        field.Type = TType.String;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.condition);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("UpdateEdgeRequest(");
      sb.Append("space_id: ");
      sb.Append(this.space_id);
      sb.Append(",part_id: ");
      sb.Append(this.part_id);
      sb.Append(",edge_key: ");
      sb.Append(this.edge_key== null ? "<null>" : this.edge_key.ToString());
      sb.Append(",updated_props: ");
      sb.Append(this.updated_props);
      sb.Append(",insertable: ");
      sb.Append(this.insertable);
      sb.Append(",return_props: ");
      sb.Append(this.return_props);
      sb.Append(",condition: ");
      sb.Append(this.condition);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
