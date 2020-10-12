# coreBlog
a blog in dot net core 3.1


Drop currect db (if necessary)
`dotnet-ef database drop -v`

Migrate using PostContext
`dotnet-ef database update --context=PostContext -v`
