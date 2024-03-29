﻿using UnityEngine;

namespace Kogane
{
    /// <summary>
    /// IJson 型の拡張メソッドを管理するクラス
    /// </summary>
    public static class IJsonExtensionMethods
    {
        //================================================================================
        // 関数（static）
        //================================================================================
        /// <summary>
        /// 指定されたインスタンスを Json 形式の文字列に変換して返します
        /// </summary>
        public static string ToJson( this IJson self )
        {
            return JsonUtility.ToJson( self );
        }

        /// <summary>
        /// 指定されたインスタンスを Json 形式の文字列に変換して返します
        /// </summary>
        public static string ToJson( this IJson self, bool prettyPrint )
        {
            return JsonUtility.ToJson( self, prettyPrint );
        }

        /// <summary>
        /// 指定されたインスタンスを整形された Json 形式の文字列に変換して返します
        /// </summary>
        public static string ToReadableJson( this IJson self )
        {
            return JsonUtility.ToJson( self, true );
        }
    }
}