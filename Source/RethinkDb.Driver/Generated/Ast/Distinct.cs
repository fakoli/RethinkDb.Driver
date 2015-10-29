












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

    public class Distinct : ReqlExpr {

    
    
    
/// <summary>
/// <para>Remove duplicate elements from the sequence.</para>
/// </summary>
/// <example><para>Example: Which unique villains have been vanquished by marvel heroes?</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('villainList')
/// }).distinct().run(conn, callback)
/// </code></example>
        public Distinct (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Remove duplicate elements from the sequence.</para>
/// </summary>
/// <example><para>Example: Which unique villains have been vanquished by marvel heroes?</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('villainList')
/// }).distinct().run(conn, callback)
/// </code></example>
        public Distinct (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Remove duplicate elements from the sequence.</para>
/// </summary>
/// <example><para>Example: Which unique villains have been vanquished by marvel heroes?</para>
/// <code>r.table('marvel').concatMap(function(hero) {
///     return hero('villainList')
/// }).distinct().run(conn, callback)
/// </code></example>
        public Distinct (Arguments args, OptArgs optargs)
         : base(TermType.DISTINCT, args, optargs) {
        }


    



    
///<summary>
/// "index": "T_STR"
///</summary>
        public Distinct this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new Distinct (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "index": "T_STR"
///</summary>
        public Distinct optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new Distinct (this.Args, newOptargs);
        }


    

    


    
    }
}
