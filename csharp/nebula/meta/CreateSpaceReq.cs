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
  public partial class CreateSpaceReq : TBase
  {
    private SpaceDesc properties;
    private bool if_not_exists;

    public SpaceDesc Properties
    {
      get
      {
        return properties;
      }
      set
      {
        __isset.properties = true;
        this.properties = value;
      }
    }

    public bool If_not_exists
    {
      get
      {
        return if_not_exists;
      }
      set
      {
        __isset.if_not_exists = true;
        this.if_not_exists = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool properties;
      public bool if_not_exists;
    }

    public CreateSpaceReq() {
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
              this.properties = new SpaceDesc();
              this.properties.Read(iprot);
              this.__isset.properties = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Bool) {
              this.if_not_exists = iprot.ReadBool();
              this.__isset.if_not_exists = true;
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
      TStruct struc = new TStruct("CreateSpaceReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.properties != null && __isset.properties) {
        field.Name = "properties";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        this.properties.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (__isset.if_not_exists) {
        field.Name = "if_not_exists";
        field.Type = TType.Bool;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteBool(this.if_not_exists);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("CreateSpaceReq(");
      sb.Append("properties: ");
      sb.Append(this.properties== null ? "<null>" : this.properties.ToString());
      sb.Append(",if_not_exists: ");
      sb.Append(this.if_not_exists);
      sb.Append(")");
      return sb.ToString();
    }

  }

}