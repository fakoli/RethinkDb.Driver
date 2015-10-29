












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

    public class IndexRename : ReqlExpr {

    
    
    
/// <summary>
/// <para>Rename an existing secondary index on a table. If the optional argument <code>overwrite</code> is specified as <code>true</code>, a previously existing index with the new name will be deleted and the index will be renamed. If <code>overwrite</code> is <code>false</code> (the default) an error will be raised if the new index name already exists.</para>
/// </summary>
/// <example><para>Example: Rename an index on the comments table.</para>
/// <code>r.table('comments').indexRename('postId', 'messageId').run(conn, callback)
/// </code></example>
        public IndexRename (object arg) : this(new Arguments(arg), null) {
        }
/// <summary>
/// <para>Rename an existing secondary index on a table. If the optional argument <code>overwrite</code> is specified as <code>true</code>, a previously existing index with the new name will be deleted and the index will be renamed. If <code>overwrite</code> is <code>false</code> (the default) an error will be raised if the new index name already exists.</para>
/// </summary>
/// <example><para>Example: Rename an index on the comments table.</para>
/// <code>r.table('comments').indexRename('postId', 'messageId').run(conn, callback)
/// </code></example>
        public IndexRename (Arguments args) : this(args, null) {
        }
/// <summary>
/// <para>Rename an existing secondary index on a table. If the optional argument <code>overwrite</code> is specified as <code>true</code>, a previously existing index with the new name will be deleted and the index will be renamed. If <code>overwrite</code> is <code>false</code> (the default) an error will be raised if the new index name already exists.</para>
/// </summary>
/// <example><para>Example: Rename an index on the comments table.</para>
/// <code>r.table('comments').indexRename('postId', 'messageId').run(conn, callback)
/// </code></example>
        public IndexRename (Arguments args, OptArgs optargs)
         : base(TermType.INDEX_RENAME, args, optargs) {
        }


    



    
///<summary>
/// "overwrite": "T_BOOL"
///</summary>
        public IndexRename this[object optArgs] {
            get
            {
                var newOptargs = OptArgs.fromMap(this.OptArgs).with(optArgs);
        
                return new IndexRename (this.Args, newOptargs);
            }
        }
        
///<summary>
/// "overwrite": "T_BOOL"
///</summary>
        public IndexRename optArg(string key, object val){
            
            var newOptargs = OptArgs.fromMap(this.OptArgs).with(key, val);
        
            return new IndexRename (this.Args, newOptargs);
        }


    

    


    
    }
}
