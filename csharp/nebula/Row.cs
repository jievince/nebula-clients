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
  public partial class Row : TBase
  {
    private List<Value> values;

    public List<Value> Values
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
      public bool values;
    }

    public Row() {
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
                this.values = new List<Value>();
                TList _list13 = iprot.ReadListBegin();
                for( int _i14 = 0; _i14 < _list13.Count; ++_i14)
                {
                  Value _elem15 = new Value();
                  _elem15 = new Value();
                  _elem15.Read(iprot);
                  this.values.Add(_elem15);
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
      TStruct struc = new TStruct("Row");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.values != null && __isset.values) {
        field.Name = "values";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.values.Count));
          foreach (Value _iter16 in this.values)
          {
            _iter16.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Row(");
      sb.Append("values: ");
      sb.Append(this.values);
      sb.Append(")");
      return sb.ToString();
    }

  }

}