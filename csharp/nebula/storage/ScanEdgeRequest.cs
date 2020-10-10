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
  public partial class ScanEdgeRequest : TBase
  {
    private int space_id;
    private int part_id;
    private byte[] cursor;
    private List<EdgeProp> return_columns;
    private bool no_columns;
    private int limit;
    private long start_time;
    private long end_time;

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

    public byte[] Cursor
    {
      get
      {
        return cursor;
      }
      set
      {
        __isset.cursor = true;
        this.cursor = value;
      }
    }

    public List<EdgeProp> Return_columns
    {
      get
      {
        return return_columns;
      }
      set
      {
        __isset.return_columns = true;
        this.return_columns = value;
      }
    }

    public bool No_columns
    {
      get
      {
        return no_columns;
      }
      set
      {
        __isset.no_columns = true;
        this.no_columns = value;
      }
    }

    public int Limit
    {
      get
      {
        return limit;
      }
      set
      {
        __isset.limit = true;
        this.limit = value;
      }
    }

    public long Start_time
    {
      get
      {
        return start_time;
      }
      set
      {
        __isset.start_time = true;
        this.start_time = value;
      }
    }

    public long End_time
    {
      get
      {
        return end_time;
      }
      set
      {
        __isset.end_time = true;
        this.end_time = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool space_id;
      public bool part_id;
      public bool cursor;
      public bool return_columns;
      public bool no_columns;
      public bool limit;
      public bool start_time;
      public bool end_time;
    }

    public ScanEdgeRequest() {
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
            if (field.Type == TType.String) {
              this.cursor = iprot.ReadBinary();
              this.__isset.cursor = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                this.return_columns = new List<EdgeProp>();
                TList _list179 = iprot.ReadListBegin();
                for( int _i180 = 0; _i180 < _list179.Count; ++_i180)
                {
                  EdgeProp _elem181 = new EdgeProp();
                  _elem181 = new EdgeProp();
                  _elem181.Read(iprot);
                  this.return_columns.Add(_elem181);
                }
                iprot.ReadListEnd();
              }
              this.__isset.return_columns = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.Bool) {
              this.no_columns = iprot.ReadBool();
              this.__isset.no_columns = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.I32) {
              this.limit = iprot.ReadI32();
              this.__isset.limit = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.I64) {
              this.start_time = iprot.ReadI64();
              this.__isset.start_time = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 8:
            if (field.Type == TType.I64) {
              this.end_time = iprot.ReadI64();
              this.__isset.end_time = true;
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
      TStruct struc = new TStruct("ScanEdgeRequest");
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
      if (this.cursor != null && __isset.cursor) {
        field.Name = "cursor";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.cursor);
        oprot.WriteFieldEnd();
      }
      if (this.return_columns != null && __isset.return_columns) {
        field.Name = "return_columns";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.return_columns.Count));
          foreach (EdgeProp _iter182 in this.return_columns)
          {
            _iter182.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.no_columns) {
        field.Name = "no_columns";
        field.Type = TType.Bool;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(this.no_columns);
        oprot.WriteFieldEnd();
      }
      if (__isset.limit) {
        field.Name = "limit";
        field.Type = TType.I32;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.limit);
        oprot.WriteFieldEnd();
      }
      if (__isset.start_time) {
        field.Name = "start_time";
        field.Type = TType.I64;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(this.start_time);
        oprot.WriteFieldEnd();
      }
      if (__isset.end_time) {
        field.Name = "end_time";
        field.Type = TType.I64;
        field.ID = 8;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(this.end_time);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ScanEdgeRequest(");
      sb.Append("space_id: ");
      sb.Append(this.space_id);
      sb.Append(",part_id: ");
      sb.Append(this.part_id);
      sb.Append(",cursor: ");
      sb.Append(this.cursor);
      sb.Append(",return_columns: ");
      sb.Append(this.return_columns);
      sb.Append(",no_columns: ");
      sb.Append(this.no_columns);
      sb.Append(",limit: ");
      sb.Append(this.limit);
      sb.Append(",start_time: ");
      sb.Append(this.start_time);
      sb.Append(",end_time: ");
      sb.Append(this.end_time);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
