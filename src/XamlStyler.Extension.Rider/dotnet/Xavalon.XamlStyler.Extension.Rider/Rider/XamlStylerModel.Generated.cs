//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a RdGen v1.08.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using JetBrains.Annotations;

using JetBrains.Core;
using JetBrains.Diagnostics;
using JetBrains.Collections;
using JetBrains.Collections.Viewable;
using JetBrains.Lifetimes;
using JetBrains.Serialization;
using JetBrains.Rd;
using JetBrains.Rd.Base;
using JetBrains.Rd.Impl;
using JetBrains.Rd.Tasks;
using JetBrains.Rd.Util;
using JetBrains.Rd.Text;


// ReSharper disable RedundantEmptyObjectCreationArgumentList
// ReSharper disable InconsistentNaming
// ReSharper disable RedundantOverflowCheckingContext


namespace JetBrains.Rider.Model
{
  
  
  /// <summary>
  /// <p>Generated from: XamlStylerModel.kt:12</p>
  /// </summary>
  public class XamlStylerModel : RdExtBase
  {
    //fields
    //public fields
    [NotNull] public IRdEndpoint<RdXamlStylerFormattingRequest, RdXamlStylerFormattingResult> PerformReformat => _PerformReformat;
    
    //private fields
    [NotNull] private readonly RdCall<RdXamlStylerFormattingRequest, RdXamlStylerFormattingResult> _PerformReformat;
    
    //primary constructor
    private XamlStylerModel(
      [NotNull] RdCall<RdXamlStylerFormattingRequest, RdXamlStylerFormattingResult> performReformat
    )
    {
      if (performReformat == null) throw new ArgumentNullException("performReformat");
      
      _PerformReformat = performReformat;
      _PerformReformat.Async = true;
      BindableChildren.Add(new KeyValuePair<string, object>("performReformat", _PerformReformat));
    }
    //secondary constructor
    internal XamlStylerModel (
    ) : this (
      new RdCall<RdXamlStylerFormattingRequest, RdXamlStylerFormattingResult>(RdXamlStylerFormattingRequest.Read, RdXamlStylerFormattingRequest.Write, RdXamlStylerFormattingResult.Read, RdXamlStylerFormattingResult.Write)
    ) {}
    //deconstruct trait
    //statics
    
    
    
    protected override long SerializationHash => -3355681540747534071L;
    
    protected override Action<ISerializers> Register => RegisterDeclaredTypesSerializers;
    public static void RegisterDeclaredTypesSerializers(ISerializers serializers)
    {
      
      serializers.RegisterToplevelOnce(typeof(IdeRoot), IdeRoot.RegisterDeclaredTypesSerializers);
    }
    
    
    //constants
    
    //custom body
    //methods
    //equals trait
    //hash code trait
    //pretty print
    public override void Print(PrettyPrinter printer)
    {
      printer.Println("XamlStylerModel (");
      using (printer.IndentCookie()) {
        printer.Print("performReformat = "); _PerformReformat.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  public static class SolutionXamlStylerModelEx
   {
    public static XamlStylerModel GetXamlStylerModel(this Solution solution)
    {
      return solution.GetOrCreateExtension("xamlStylerModel", () => new XamlStylerModel());
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: XamlStylerModel.kt:14</p>
  /// </summary>
  public sealed class RdXamlStylerFormattingRequest : IPrintable, IEquatable<RdXamlStylerFormattingRequest>
  {
    //fields
    //public fields
    [NotNull] public string FilePath {get; private set;}
    [NotNull] public string DocumentText {get; private set;}
    
    //private fields
    //primary constructor
    public RdXamlStylerFormattingRequest(
      [NotNull] string filePath,
      [NotNull] string documentText
    )
    {
      if (filePath == null) throw new ArgumentNullException("filePath");
      if (documentText == null) throw new ArgumentNullException("documentText");
      
      FilePath = filePath;
      DocumentText = documentText;
    }
    //secondary constructor
    //deconstruct trait
    public void Deconstruct([NotNull] out string filePath, [NotNull] out string documentText)
    {
      filePath = FilePath;
      documentText = DocumentText;
    }
    //statics
    
    public static CtxReadDelegate<RdXamlStylerFormattingRequest> Read = (ctx, reader) => 
    {
      var filePath = reader.ReadString();
      var documentText = reader.ReadString();
      var _result = new RdXamlStylerFormattingRequest(filePath, documentText);
      return _result;
    };
    
    public static CtxWriteDelegate<RdXamlStylerFormattingRequest> Write = (ctx, writer, value) => 
    {
      writer.Write(value.FilePath);
      writer.Write(value.DocumentText);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((RdXamlStylerFormattingRequest) obj);
    }
    public bool Equals(RdXamlStylerFormattingRequest other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return FilePath == other.FilePath && DocumentText == other.DocumentText;
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        hash = hash * 31 + FilePath.GetHashCode();
        hash = hash * 31 + DocumentText.GetHashCode();
        return hash;
      }
    }
    //pretty print
    public void Print(PrettyPrinter printer)
    {
      printer.Println("RdXamlStylerFormattingRequest (");
      using (printer.IndentCookie()) {
        printer.Print("filePath = "); FilePath.PrintEx(printer); printer.Println();
        printer.Print("documentText = "); DocumentText.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
  
  
  /// <summary>
  /// <p>Generated from: XamlStylerModel.kt:19</p>
  /// </summary>
  public sealed class RdXamlStylerFormattingResult : IPrintable, IEquatable<RdXamlStylerFormattingResult>
  {
    //fields
    //public fields
    public bool IsSuccess {get; private set;}
    public bool HasUpdated {get; private set;}
    [NotNull] public string FormattedText {get; private set;}
    
    //private fields
    //primary constructor
    public RdXamlStylerFormattingResult(
      bool isSuccess,
      bool hasUpdated,
      [NotNull] string formattedText
    )
    {
      if (formattedText == null) throw new ArgumentNullException("formattedText");
      
      IsSuccess = isSuccess;
      HasUpdated = hasUpdated;
      FormattedText = formattedText;
    }
    //secondary constructor
    //deconstruct trait
    public void Deconstruct(out bool isSuccess, out bool hasUpdated, [NotNull] out string formattedText)
    {
      isSuccess = IsSuccess;
      hasUpdated = HasUpdated;
      formattedText = FormattedText;
    }
    //statics
    
    public static CtxReadDelegate<RdXamlStylerFormattingResult> Read = (ctx, reader) => 
    {
      var isSuccess = reader.ReadBool();
      var hasUpdated = reader.ReadBool();
      var formattedText = reader.ReadString();
      var _result = new RdXamlStylerFormattingResult(isSuccess, hasUpdated, formattedText);
      return _result;
    };
    
    public static CtxWriteDelegate<RdXamlStylerFormattingResult> Write = (ctx, writer, value) => 
    {
      writer.Write(value.IsSuccess);
      writer.Write(value.HasUpdated);
      writer.Write(value.FormattedText);
    };
    
    //constants
    
    //custom body
    //methods
    //equals trait
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj)) return false;
      if (ReferenceEquals(this, obj)) return true;
      if (obj.GetType() != GetType()) return false;
      return Equals((RdXamlStylerFormattingResult) obj);
    }
    public bool Equals(RdXamlStylerFormattingResult other)
    {
      if (ReferenceEquals(null, other)) return false;
      if (ReferenceEquals(this, other)) return true;
      return IsSuccess == other.IsSuccess && HasUpdated == other.HasUpdated && FormattedText == other.FormattedText;
    }
    //hash code trait
    public override int GetHashCode()
    {
      unchecked {
        var hash = 0;
        hash = hash * 31 + IsSuccess.GetHashCode();
        hash = hash * 31 + HasUpdated.GetHashCode();
        hash = hash * 31 + FormattedText.GetHashCode();
        return hash;
      }
    }
    //pretty print
    public void Print(PrettyPrinter printer)
    {
      printer.Println("RdXamlStylerFormattingResult (");
      using (printer.IndentCookie()) {
        printer.Print("isSuccess = "); IsSuccess.PrintEx(printer); printer.Println();
        printer.Print("hasUpdated = "); HasUpdated.PrintEx(printer); printer.Println();
        printer.Print("formattedText = "); FormattedText.PrintEx(printer); printer.Println();
      }
      printer.Print(")");
    }
    //toString
    public override string ToString()
    {
      var printer = new SingleLinePrettyPrinter();
      Print(printer);
      return printer.ToString();
    }
  }
}
