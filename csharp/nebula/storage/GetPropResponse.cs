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
  public partial class GetPropResponse : TBase
  {
    private ResponseCommon result;
    private nebula.DataSet props;

    public ResponseCommon Result
    {
      get
      {
        return result;
      }
      set
      {
        __isset.result = true;
        this.result = value;
      }
    }

    public nebula.DataSet Props
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
      public bool result;
      public bool props;
    }

    public GetPropResponse() {
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
              this.result = new ResponseCommon();
              this.result.Read(iprot);
              this.__isset.result = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              this.props = new nebula.DataSet();
              this.props.Read(iprot);
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
      TStruct struc = new TStruct("GetPropResponse");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.result != null && __isset.result) {
        field.Name = "result";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        this.result.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.props != null && __isset.props) {
        field.Name = "props";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        this.props.Write(oprot);
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("GetPropResponse(");
      sb.Append("result: ");
      sb.Append(this.result== null ? "<null>" : this.result.ToString());
      sb.Append(",props: ");
      sb.Append(this.props== null ? "<null>" : this.props.ToString());
      sb.Append(")");
      return sb.ToString();
    }

  }

}
