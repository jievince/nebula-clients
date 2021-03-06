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
  public partial class NewEdge : TBase
  {
    private EdgeKey key;
    private List<nebula.Value> props;

    public EdgeKey Key
    {
      get
      {
        return key;
      }
      set
      {
        __isset.key = true;
        this.key = value;
      }
    }

    public List<nebula.Value> Props
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
      public bool key;
      public bool props;
    }

    public NewEdge() {
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
            if (field.Type == TType.Struct) {
              this.key = new EdgeKey();
              this.key.Read(iprot);
              this.__isset.key = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                this.props = new List<nebula.Value>();
                TList _list86 = iprot.ReadListBegin();
                for( int _i87 = 0; _i87 < _list86.Count; ++_i87)
                {
                  nebula.Value _elem88 = new nebula.Value();
                  _elem88 = new nebula.Value();
                  _elem88.Read(iprot);
                  this.props.Add(_elem88);
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
      TStruct struc = new TStruct("NewEdge");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.key != null && __isset.key) {
        field.Name = "key";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        this.key.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.props != null && __isset.props) {
        field.Name = "props";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.props.Count));
          foreach (nebula.Value _iter89 in this.props)
          {
            _iter89.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("NewEdge(");
      sb.Append("key: ");
      sb.Append(this.key== null ? "<null>" : this.key.ToString());
      sb.Append(",props: ");
      sb.Append(this.props);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
