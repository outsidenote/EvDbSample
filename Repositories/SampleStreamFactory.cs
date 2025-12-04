namespace Repositories;
using EvDb.Core;
using Abstractions;

[EvDbAttachView<View1>]
[EvDbStreamFactory<IEventsSet>("sample_stream")]
public partial class SampleStreamFactory
{
    
}