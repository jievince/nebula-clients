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
namespace nebula.graph
{

  [Serializable]
  public partial class PlanNodeDescription : TBase
  {
    private byte[] name;
    private long id;
    private byte[] output_var;
    private List<Pair> description;
    private List<ProfilingStats> profiles;
    private PlanNodeBranchInfo branch_info;
    private List<long> dependencies;

    public byte[] Name
    {
      get
      {
        return name;
      }
      set
      {
        __isset.name = true;
        this.name = value;
      }
    }

    public long Id
    {
      get
      {
        return id;
      }
      set
      {
        __isset.id = true;
        this.id = value;
      }
    }

    public byte[] Output_var
    {
      get
      {
        return output_var;
      }
      set
      {
        __isset.output_var = true;
        this.output_var = value;
      }
    }

    public List<Pair> Description
    {
      get
      {
        return description;
      }
      set
      {
        __isset.description = true;
        this.description = value;
      }
    }

    public List<ProfilingStats> Profiles
    {
      get
      {
        return profiles;
      }
      set
      {
        __isset.profiles = true;
        this.profiles = value;
      }
    }

    public PlanNodeBranchInfo Branch_info
    {
      get
      {
        return branch_info;
      }
      set
      {
        __isset.branch_info = true;
        this.branch_info = value;
      }
    }

    public List<long> Dependencies
    {
      get
      {
        return dependencies;
      }
      set
      {
        __isset.dependencies = true;
        this.dependencies = value;
      }
    }


    public Isset __isset;
    [Serializable]
    public struct Isset {
      public bool name;
      public bool id;
      public bool output_var;
      public bool description;
      public bool profiles;
      public bool branch_info;
      public bool dependencies;
    }

    public PlanNodeDescription() {
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
            if (field.Type == TType.String) {
              this.name = iprot.ReadBinary();
              this.__isset.name = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.I64) {
              this.id = iprot.ReadI64();
              this.__isset.id = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.String) {
              this.output_var = iprot.ReadBinary();
              this.__isset.output_var = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 4:
            if (field.Type == TType.List) {
              {
                this.description = new List<Pair>();
                TList _list5 = iprot.ReadListBegin();
                for( int _i6 = 0; _i6 < _list5.Count; ++_i6)
                {
                  Pair _elem7 = new Pair();
                  _elem7 = new Pair();
                  _elem7.Read(iprot);
                  this.description.Add(_elem7);
                }
                iprot.ReadListEnd();
              }
              this.__isset.description = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 5:
            if (field.Type == TType.List) {
              {
                this.profiles = new List<ProfilingStats>();
                TList _list8 = iprot.ReadListBegin();
                for( int _i9 = 0; _i9 < _list8.Count; ++_i9)
                {
                  ProfilingStats _elem10 = new ProfilingStats();
                  _elem10 = new ProfilingStats();
                  _elem10.Read(iprot);
                  this.profiles.Add(_elem10);
                }
                iprot.ReadListEnd();
              }
              this.__isset.profiles = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 6:
            if (field.Type == TType.Struct) {
              this.branch_info = new PlanNodeBranchInfo();
              this.branch_info.Read(iprot);
              this.__isset.branch_info = true;
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 7:
            if (field.Type == TType.List) {
              {
                this.dependencies = new List<long>();
                TList _list11 = iprot.ReadListBegin();
                for( int _i12 = 0; _i12 < _list11.Count; ++_i12)
                {
                  long _elem13 = 0;
                  _elem13 = iprot.ReadI64();
                  this.dependencies.Add(_elem13);
                }
                iprot.ReadListEnd();
              }
              this.__isset.dependencies = true;
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
      TStruct struc = new TStruct("PlanNodeDescription");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (this.name != null && __isset.name) {
        field.Name = "name";
        field.Type = TType.String;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.name);
        oprot.WriteFieldEnd();
      }
      if (__isset.id) {
        field.Name = "id";
        field.Type = TType.I64;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        oprot.WriteI64(this.id);
        oprot.WriteFieldEnd();
      }
      if (this.output_var != null && __isset.output_var) {
        field.Name = "output_var";
        field.Type = TType.String;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        oprot.WriteBinary(this.output_var);
        oprot.WriteFieldEnd();
      }
      if (this.description != null && __isset.description) {
        field.Name = "description";
        field.Type = TType.List;
        field.ID = 4;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.description.Count));
          foreach (Pair _iter14 in this.description)
          {
            _iter14.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (this.profiles != null && __isset.profiles) {
        field.Name = "profiles";
        field.Type = TType.List;
        field.ID = 5;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.Struct, this.profiles.Count));
          foreach (ProfilingStats _iter15 in this.profiles)
          {
            _iter15.Write(oprot);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      if (this.branch_info != null && __isset.branch_info) {
        field.Name = "branch_info";
        field.Type = TType.Struct;
        field.ID = 6;
        oprot.WriteFieldBegin(field);
        this.branch_info.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (this.dependencies != null && __isset.dependencies) {
        field.Name = "dependencies";
        field.Type = TType.List;
        field.ID = 7;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteListBegin(new TList(TType.I64, this.dependencies.Count));
          foreach (long _iter16 in this.dependencies)
          {
            oprot.WriteI64(_iter16);
            oprot.WriteListEnd();
          }
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }

    public override string ToString() {
      StringBuilder sb = new StringBuilder("PlanNodeDescription(");
      sb.Append("name: ");
      sb.Append(this.name);
      sb.Append(",id: ");
      sb.Append(this.id);
      sb.Append(",output_var: ");
      sb.Append(this.output_var);
      sb.Append(",description: ");
      sb.Append(this.description);
      sb.Append(",profiles: ");
      sb.Append(this.profiles);
      sb.Append(",branch_info: ");
      sb.Append(this.branch_info== null ? "<null>" : this.branch_info.ToString());
      sb.Append(",dependencies: ");
      sb.Append(this.dependencies);
      sb.Append(")");
      return sb.ToString();
    }

  }

}
