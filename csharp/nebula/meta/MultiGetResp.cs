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
  public partial class MultiGetResp : TBase
  {
    private ErrorCode code;
    private nebula.HostAddr leader;
    private List<byte[]> values;

    public ErrorCode Code
    {
      get
      {
        return code;
      }
      set
      {
        __isset.code = true;
        this.code = value;
      }
    }

    public nebula.HostAddr Leader
    {
      get
      {
        return leader;
      }
      set
      {
        __isset.leader = true;
        this.leader = value;
      }
    }

    public List<byte[]> Values
    {
      get
      {
        return values;
      }
      set
      {
        __isset.values = true;
        this.values = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool code;
      public bool leader;
      public bool values;
    }

    public MultiGetResp() {
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
              this.code = (ErrorCode)iprot.ReadI32();
              this.__isset.code = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              this.leader = new nebula.HostAddr();
              this.leader.Read(iprot);
              this.__isset.leader = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.List) {
              {
                this.values = new List<byte[]>();
                TList _list99 = iprot.ReadListBegin();
                for( int _i100 = 0; _i100 < _list99.Count; ++_i100)
                {
                  byte[] _elem101 = null;
                  _elem101 = iprot.ReadBinary();
                  this.values.Add(_elem101);
                }
                iprot.ReadListEnd();
              }
              this.__isset.values = true;
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
      TStruct struc = new TStruct("MultiGetResp");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.code) {
        field.Name = "code";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32((int)this.code);
        oprot.WriteFieldEnd();
      }
      if (this.leader != null && __isset.leader) {
        field.Name = "leader";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        this.leader.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.values != null && __isset.values) {
        field.Name = "values";
        field.Type = TType.List;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, this.values.Count));
          foreach (byte[] _iter102 in this.values)
          {
            oprot.WriteBinary(_iter102);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("MultiGetResp(");
      sb.Append("code: ");
      sb.Append(this.code);
      sb.Append(",leader: ");
      sb.Append(this.leader== null ? "<null>" : this.leader.ToString());
      sb.Append(",values: ");
      sb.Append(this.values);
      sb.Append(")");
      return sb.ToString();
    }

  }

}