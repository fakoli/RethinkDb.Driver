












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

    public class Append : ReqlExpr {

    
    
    
/// <summary>
/// <para>Append a value to an array.</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list with the addition of some new boots.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').append('newBoots').run(conn, callback)
/// </code></example>
        public Append (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Append a value to an array.</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list with the addition of some new boots.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').append('newBoots').run(conn, callback)
/// </code></example>
        public Append (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Append a value to an array.</para>
/// </summary>
/// <example><para>Example: Retrieve Iron Man's equipment list with the addition of some new boots.</para>
/// <code>r.table('marvel').get('IronMan')('equipment').append('newBoots').run(conn, callback)
/// </code></example>
        public Append (Arguments args, OptArgs optargs)
         : base(TermType.APPEND, args, optargs) {
        }


    



    


    

    


    
    }
}
