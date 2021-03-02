/*
 * Copyright (c) MDD4All.de, Dr. Oliver Alt
 */
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace MDD4All.Jira.DataModels.Converters
{
    //public class DescriptionConverter : JsonConverter
    //{
    //    public override bool CanConvert(Type objectType)
    //    {
    //        return true;
    //    }

    //    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    //    {
    //        Description result = new Description();

    //        if (reader.ValueType != null)
    //        {
    //            if (reader.ValueType == typeof(string))
    //            {
    //                result.StringValue = reader.Value.ToString();
    //            }
    //            else
    //            {
    //                var val = reader.Value;
    //                ;
    //            }
    //        }
    //        else
    //        {
    //            result.StringValue = "";
    //        }

    //        return result;
    //    }

    //    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
