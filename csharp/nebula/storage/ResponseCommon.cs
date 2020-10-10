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
  public partial class ResponseCommon : TBase
  {
    private List<PartitionResult> failed_parts;
    private int latency_in_us;

    public List<PartitionResult> Failed_parts
    {
      get
      {
        return failed_parts;
      }
      set
      {
        __isset.failed_parts = true;
        this.failed_parts = value;
      }
    }

    public int Latency_in_us
    {
      get
      {
        return latency_in_us;
      }
      set
      {
        __isset.latency_in_us = true;
        this.latency_in_us = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool failed_parts;
      public bool latency_in_us;
    }

    public ResponseCommon() {
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
                this.failed_parts = new List<PartitionResult>();
                TList _list0 = iprot.ReadListBegin();
                for( int _i1 = 0; _i1 < _list0.Count; ++_i1)
                {
                  PartitionResult _elem2 = new PartitionResult();
                  _elem2 = new PartitionResult();
                  _elem2.Read(iprot);
                  this.failed_parts.Add(_elem2);
                }
                iprot.ReadListEnd();
              }
              this.__isset.failed_parts = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I32) {
              this.latency_in_us = iprot.ReadI32();
              this.__isset.latency_in_us = true;
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
      TStruct struc = new TStruct("ResponseCommon");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.failed_parts != null && __isset.failed_parts) {
        field.Name = "failed_parts";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.failed_parts.Count));
          foreach (PartitionResult _iter3 in this.failed_parts)
          {
            _iter3.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (__isset.latency_in_us) {
        field.Name = "latency_in_us";
        field.Type = TType.I32;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.latency_in_us);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("ResponseCommon(");
      sb.Append("failed_parts: ");
      sb.Append(this.failed_parts);
      sb.Append(",latency_in_us: ");
      sb.Append(this.latency_in_us);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
