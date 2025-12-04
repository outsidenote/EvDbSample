namespace Abstractions;
using EvDb.Core;

[EvDbDefineEventPayload("event_2")]
public partial record Event2(int value2)
{
}