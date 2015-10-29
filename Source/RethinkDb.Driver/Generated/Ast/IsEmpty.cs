












//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {

    public class IsEmpty : ReqlExpr {

    
    
    
/// <summary>
/// <para>Test if a sequence is empty.</para>
/// </summary>
/// <example><para>Example: Are there any documents in the marvel table?</para>
/// <code>r.table('marvel').isEmpty().run(conn, callback)
/// </code></example>
        public IsEmpty (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Test if a sequence is empty.</para>
/// </summary>
/// <example><para>Example: Are there any documents in the marvel table?</para>
/// <code>r.table('marvel').isEmpty().run(conn, callback)
/// </code></example>
        public IsEmpty (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Test if a sequence is empty.</para>
/// </summary>
/// <example><para>Example: Are there any documents in the marvel table?</para>
/// <code>r.table('marvel').isEmpty().run(conn, callback)
/// </code></example>
        public IsEmpty (Arguments args, OptArgs optargs)
         : base(TermType.IS_EMPTY, args, optargs) {
        }


    



    


    

    


    
    }
}
