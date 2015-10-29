












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

    public class Update : ReqlExpr {

    
    
    
/// <summary>
/// <para>Update JSON documents in a table. Accepts a JSON document, a ReQL expression, or a
/// combination of the two. You can pass options like <code>returnChanges</code> that will return the old
/// and new values of the row you have modified.</para>
/// </summary>
/// <example><para>Example: Update the status of the post with <code>id</code> of <code>1</code> to <code>published</code>.</para>
/// <code>r.table("posts").get(1).update({status: "published"}).run(conn, callback)
/// </code></example>
        public Update (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Update JSON documents in a table. Accepts a JSON document, a ReQL expression, or a
/// combination of the two. You can pass options like <code>returnChanges</code> that will return the old
/// and new values of the row you have modified.</para>
/// </summary>
/// <example><para>Example: Update the status of the post with <code>id</code> of <code>1</code> to <code>published</code>.</para>
/// <code>r.table("posts").get(1).update({status: "published"}).run(conn, callback)
/// </code></example>
        public Update (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Update JSON documents in a table. Accepts a JSON document, a ReQL expression, or a
/// combination of the two. You can pass options like <code>returnChanges</code> that will return the old
/// and new values of the row you have modified.</para>
/// </summary>
/// <example><para>Example: Update the status of the post with <code>id</code> of <code>1</code> to <code>published</code>.</para>
/// <code>r.table("posts").get(1).update({status: "published"}).run(conn, callback)
/// </code></example>
        public Update (Arguments args, OptArgs optargs)
         : base(TermType.UPDATE, args, optargs) {
        }


    



    
///<summary>
/// "durability": "E_DURABILITY",
///  "return_changes": [
///    "T_BOOL",
///    "always"
///  ],
///  "non_atomic": "T_BOOL"
///</summary>
        public Update this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new Update (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "durability": "E_DURABILITY",
///  "return_changes": [
///    "T_BOOL",
///    "always"
///  ],
///  "non_atomic": "T_BOOL"
///</summary>
        public Update optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new Update (this.Args, newOptargs);
        }


    

    


    
    }
}
