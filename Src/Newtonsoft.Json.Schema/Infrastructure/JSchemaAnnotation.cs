#region License
// Copyright (c) Newtonsoft. All Rights Reserved.
// License: https://raw.github.com/JamesNK/Newtonsoft.Json.Schema/master/LICENSE.md
#endregion

namespace Newtonsoft.Json.Schema.Infrastructure
{
    internal class JSchemaAnnotation
    {
        public readonly JSchema Schema;

        public JSchemaAnnotation(JSchema schema)
        {
            Schema = schema;
        }
    }
}