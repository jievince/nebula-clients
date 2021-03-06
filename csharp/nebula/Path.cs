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
  public partial class Path : TBase
  {
    private Vertex src;
    private List<Step> steps;

    public Vertex Src
    {
      get
      {
        return src;
      }
      set
      {
        __isset.src = true;
        this.src = value;
      }
    }

    public List<Step> Steps
    {
      get
      {
        return steps;
      }
      set
      {
        __isset.steps = true;
        this.steps = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool src;
      public bool steps;
    }

    public Path() {
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
              this.src = new Vertex();
              this.src.Read(iprot);
              this.__isset.src = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.List) {
              {
                this.steps = new List<Step>();
                TList _list44 = iprot.ReadListBegin();
                for( int _i45 = 0; _i45 < _list44.Count; ++_i45)
                {
                  Step _elem46 = new Step();
                  _elem46 = new Step();
                  _elem46.Read(iprot);
                  this.steps.Add(_elem46);
                }
                iprot.ReadListEnd();
              }
              this.__isset.steps = true;
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
      TStruct struc = new TStruct("Path");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.src != null && __isset.src) {
        field.Name = "src";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        this.src.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.steps != null && __isset.steps) {
        field.Name = "steps";
        field.Type = TType.List;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.steps.Count));
          foreach (Step _iter47 in this.steps)
          {
            _iter47.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("Path(");
      sb.Append("src: ");
      sb.Append(this.src== null ? "<null>" : this.src.ToString());
      sb.Append(",steps: ");
      sb.Append(this.steps);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
