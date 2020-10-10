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
  public partial class RegConfigReq : TBase
  {
    private List<ConfigItem> items;

    public List<ConfigItem> Items
    {
      get
      {
        return items;
      }
      set
      {
        __isset.items = true;
        this.items = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool items;
    }

    public RegConfigReq() {
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
                this.items = new List<ConfigItem>();
                TList _list149 = iprot.ReadListBegin();
                for( int _i150 = 0; _i150 < _list149.Count; ++_i150)
                {
                  ConfigItem _elem151 = new ConfigItem();
                  _elem151 = new ConfigItem();
                  _elem151.Read(iprot);
                  this.items.Add(_elem151);
                }
                iprot.ReadListEnd();
              }
              this.__isset.items = true;
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
      TStruct struc = new TStruct("RegConfigReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.items != null && __isset.items) {
        field.Name = "items";
        field.Type = TType.List;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.items.Count));
          foreach (ConfigItem _iter152 in this.items)
          {
            _iter152.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("RegConfigReq(");
      sb.Append("items: ");
      sb.Append(this.items);
      sb.Append(")");
      return sb.ToString();
    }

  }

}