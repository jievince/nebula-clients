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
  public partial class VertexProp : TBase
  {
    private int tag;
    private List<byte[]> props;

    public int Tag
    {
      get
      {
        return tag;
      }
      set
      {
        __isset.tag = true;
        this.tag = value;
      }
    }

    public List<byte[]> Props
    {
      get
      {
        return props;
      }
      set
      {
        __isset.props = true;
        this.props = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool tag;
      public bool props;
    }

    public VertexProp() {
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
              this.tag = iprot.ReadI32();
              this.__isset.tag = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                this.props = new List<byte[]>();
                TList _list8 = iprot.ReadListBegin();
                for( int _i9 = 0; _i9 < _list8.Count; ++_i9)
                {
                  byte[] _elem10 = null;
                  _elem10 = iprot.ReadBinary();
                  this.props.Add(_elem10);
                }
                iprot.ReadListEnd();
              }
              this.__isset.props = true;
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
      TStruct struc = new TStruct("VertexProp");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (__isset.tag) {
        field.Name = "tag";
        field.Type = TType.I32;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteI32(this.tag);
        oprot.WriteFieldEnd();
      }
      if (this.props != null && __isset.props) {
        field.Name = "props";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.String, this.props.Count));
          foreach (byte[] _iter11 in this.props)
          {
            oprot.WriteBinary(_iter11);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("VertexProp(");
      sb.Append("tag: ");
      sb.Append(this.tag);
      sb.Append(",props: ");
      sb.Append(this.props);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
