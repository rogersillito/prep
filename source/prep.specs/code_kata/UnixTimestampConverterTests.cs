using Machine.Specifications;
using developwithpassion.specifications.rhinomocks;
using prep.code_kata;

namespace prep.specs.code_kata
{
    public class UnixTimestampConverterTests
    {
         public class when_a_valid_unix_timestamp_is_supplied: Observes<UnixTimestampConverter>
         {
             private Because b = () => sut.ToDateTime("1282352346");

             private It 
         }
    }
}