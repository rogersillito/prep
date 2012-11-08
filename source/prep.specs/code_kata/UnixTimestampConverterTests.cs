using System;
using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using prep.code_kata;

namespace prep.specs.code_kata
{
    public class UnixTimestampConverterTests
    {
         public class when_a_valid_unix_timestamp_is_supplied: Observes<UnixTimestampConverter>
         {
             private Because b = () => result = sut.ToDateTime("1282352340");

             It should_be_converted_to_a_correct_datetime = () =>
                 result.ShouldEqual(new DateTime(2010, 8, 20, 18, 59, 0));

             static DateTime result;
         }
    }
}