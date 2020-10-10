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
  public partial class GrantRoleReq : TBase
  {
    private RoleItem role_item;

    public RoleItem Role_item
    {
      get
      {
        return role_item;
      }
      set
      {
        __isset.role_item = true;
        this.role_item = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool role_item;
    }

    public GrantRoleReq() {
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
              this.role_item = new RoleItem();
              this.role_item.Read(iprot);
              this.__isset.role_item = true;
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
      TStruct struc = new TStruct("GrantRoleReq");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.role_item != null && __isset.role_item) {
        field.Name = "role_item";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        this.role_item.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("GrantRoleReq(");
      sb.Append("role_item: ");
      sb.Append(this.role_item== null ? "<null>" : this.role_item.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
