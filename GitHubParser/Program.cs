using Newtonsoft.Json;
using RandomFriendlyNameGenerator;
using RestSharp;
using Serilog;
using System.Diagnostics;

namespace GitHubParser {
    internal class Program {
        static void Main(string[] args) {

            GenerateName();
        }
        private static void GenerateName() {

            HashSet<string> list = [
"Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Zeta", "Eta", "Theta", "Iota", "Kappa",
    "Lambda", "Mu", "Nu", "Xi", "Omicron", "Pi", "Rho", "Sigma", "Tau", "Upsilon",
    "Phi", "Chi", "Psi", "Omega", "Apex", "Blaze", "Crest", "Dawn", "Echo", "Flare",
    "Glide", "Haven", "Ivy", "Jade", "Keen", "Lush", "Mirth", "Noble", "Oasis", "Pulse",
    "Quill", "Rift", "Sage", "Thrive", "Unity", "Vivid", "Wisp", "Xenon", "Yield", "Zephyr",
    "Azure", "Bliss", "Charm", "Dusk", "Ember", "Frost", "Glimmer", "Horizon", "Inspire", "Jubilant",
    "Kindle", "Luminous", "Mystic", "Nimbus", "Opal", "Pinnacle", "Quest", "Radiant", "Serene", "Tranquil",
    "Uplift", "Verdant", "Whisper", "Xylem", "Yearn", "Zenith", "Aether", "Brisk", "Cascade", "Drift",
    "Eclipse", "Fable", "Grove", "Haven", "Illume", "Jovial", "Kismet", "Luster", "Mingle", "Nurture",
    "Orbit", "Pioneer", "Quasar", "Reverie", "Solace", "Tide", "Utopia", "Vortex", "Wander", "Xenith",
    "Yield", "Zeal", "Aspire", "Beacon", "Cinder", "Dew", "Essence", "Fervor", "Gale", "Hearth",
    "Illuminate", "Junction", "Kaleidoscope", "Lattice", "Mosaic", "Nectar", "Ovation", "Prism", "Quintessence", "Resonance",
    "Sanctuary", "Tapestry", "Ubiquitous", "Vanguard", "Whimsy", "Xenogenesis", "Yonder", "Zodiac", "Aegis", "Brilliance",
    "Crescent", "Dynamo", "Elysium", "Finesse", "Gossamer", "Harmonic", "Incandescent", "Jubilance", "Kaleidoscope", "Luminary",
    "Mirthful", "Nebula", "Odyssey", "Paragon", "Quintessential", "Radiance", "Symphony", "Talisman", "Uplift", "Vibrant",
    "Wavelength", "Xenon", "Yonder", "Zealot", "Apex", "Blaze", "Crest", "Dawn", "Echo", "Flare",
    "Glide", "Haven", "Ivy", "Jade", "Keen", "Lush", "Mirth", "Noble", "Oasis", "Pulse",
    "Quill", "Rift", "Sage", "Thrive", "Unity", "Vivid", "Wisp", "Xenon", "Yield", "Zephyr",
    "Azure", "Bliss", "Charm", "Dusk", "Ember", "Frost", "Glimmer", "Horizon", "Inspire", "Jubilant",
    "Kindle", "Luminous", "Mystic", "Nimbus", "Opal", "Pinnacle", "Quest", "Radiant", "Serene", "Tranquil",
    "Uplift", "Verdant", "Whisper", "Xylem", "Yearn", "Zenith", "Aether", "Brisk", "Cascade", "Drift",
    "Eclipse", "Fable", "Grove", "Haven", "Illume", "Jovial", "Kismet", "Luster", "Mingle", "Nurture",
    "Orbit", "Pioneer", "Quasar", "Reverie", "Solace", "Tide", "Utopia", "Vortex", "Wander", "Xenith",
    "Yield", "Zeal", "Aspire", "Beacon", "Cinder", "Dew", "Essence", "Fervor", "Gale", "Hearth",
    "Illuminate", "Junction", "Kaleidoscope", "Lattice", "Mosaic", "Nectar", "Ovation", "Prism", "Quintessence", "Resonance",
    "Sanctuary", "Tapestry", "Ubiquitous", "Vanguard", "Whimsy", "Xenogenesis", "Yonder", "Zodiac", "Aegis", "Brilliance",
    "Crescent", "Dynamo", "Elysium", "Finesse", "Gossamer", "Harmonic", "Incandescent", "Jubilance", "Kaleidoscope", "Luminary",
    "Mirthful", "Nebula", "Odyssey", "Paragon", "Quintessential", "Radiance", "Symphony", "Talisman", "Uplift", "Vibrant",
    "Wavelength", "Xenon", "Yonder", "Zealot", "Apex", "Blaze", "Crest", "Dawn", "Echo", "Flare",
    "Glide", "Haven", "Ivy", "Jade", "Keen", "Lush", "Mirth", "Noble", "Oasis", "Pulse",
    "Quill", "Rift", "Sage", "Thrive", "Unity", "Vivid", "Wisp", "Xenon", "Yield", "Zephyr",
    "Azure", "Bliss", "Charm", "Dusk", "Ember", "Frost", "Glimmer", "Horizon", "Inspire", "Jubilant",
    "Kindle", "Luminous", "Mystic", "Nimbus", "Opal", "Pinnacle", "Quest", "Radiant", "Serene", "Tranquil",
    "Uplift", "Verdant", "Whisper", "Xylem", "Yearn", "Zenith", "Aether", "Brisk", "Cascade", "Drift",
    "Eclipse", "Fable", "Grove", "Haven", "Illume", "Jovial", "Kismet", "Luster", "Mingle", "Nurture",
    "Orbit", "Pioneer", "Quasar", "Reverie", "Solace", "Tide", "Utopia", "Vortex", "Wander", "Xenith",
    "Yield", "Zeal", "Aspire", "Beacon", "Cinder", "Dew", "Essence", "Fervor", "Gale", "Hearth",
    "Illuminate", "Junction", "Kaleidoscope", "Lattice", "Mosaic", "Nectar", "Ovation", "Prism", "Quintessence", "Resonance",
    "Sanctuary", "Tapestry", "Ubiquitous", "Vanguard", "Whimsy", "Xenogenesis", "Yonder", "Zodiac", "Aegis", "Brilliance",
    "Crescent", "Dynamo", "Elysium", "Finesse", "Gossamer", "Harmonic", "Incandescent", "Jubilance", "Kaleidoscope", "Luminary",
    "Mirthful", "Nebula", "Odyssey", "Paragon", "Quintessential", "Radiance", "Symphony", "Talisman", "Uplift", "Vibrant",
    "Wavelength", "Xenon", "Yonder", "Zealot", "Apex", "Blaze", "Crest", "Dawn", "Echo", "Flare",
    "Glide", "Haven", "Ivy", "Jade", "Keen", "Lush", "Mirth", "Noble", "Oasis", "Pulse",
    "Quill", "Rift", "Sage", "Thrive", "Unity", "Vivid", "Wisp", "Xenon", "Yield", "Zephyr",
    "Azure", "Bliss", "Charm", "Dusk", "Ember", "Frost", "Glimmer", "Horizon", "Inspire", "Jubilant",
    "Kindle", "Luminous", "Mystic", "Nimbus", "Opal", "Pinnacle", "Quest", "Radiant", "Serene", "Tranquil",
    "Uplift", "Verdant", "Whisper", "Xylem", "Yearn", "Zenith", "Aether", "Brisk", "Cascade", "Drift",
    "Eclipse", "Fable", "Grove", "Haven", "Illume"];
            

            //var a = NameGenerator.Identifiers.Get(500, IdentifierComponents.Adjective | IdentifierComponents.Noun, separator: " ", lengthRestriction: 15);
            //Console.WriteLine(a.ToArray().ToString);
            //Console.WriteLine("----------");
            var b = NameGenerator.Identifiers.Get(3000, IdentifierTemplate.GitHub, separator: " ", forceSingleLetter: true, lengthRestriction: 10);
            var str = JsonConvert.SerializeObject(b);
            File.WriteAllText(@"e:\\data1.json", str);

        }
                
        private void GrabData() {
            Log.Logger = new LoggerConfiguration()
                .WriteTo.Console()
                .WriteTo.File("e:\\log-.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();


            var githubData = new GithubData();

            List<(string name, string ext)> languages = [
                new ValueTuple<string, string>("Java", "java"),
                new ValueTuple<string, string>("Python", "py"),
                new ValueTuple<string, string>("C#", "cs"),
                new ValueTuple<string, string>("C++", "cpp"),
                new ValueTuple<string, string>("JavaScript", "js"),
                new ValueTuple<string, string>("PHP", "php"),
                new ValueTuple<string, string>("Swift", "swift"),
                new ValueTuple<string, string>("Kotlin", "kt"),
                new ValueTuple<string, string>("TypeScript", "ts"),
                new ValueTuple<string, string>("Go", "go"),
                new ValueTuple<string, string>("Rust", "rs"),
                new ValueTuple<string, string>("Scala", "scala")
            ];

            List<(string from, string to)> dates =
            [
                new ValueTuple<string, string> ("2008-01-01","2009-01-01" ),
                new ValueTuple<string, string> ("2009-01-01","2010-01-01" ),
                new ValueTuple<string, string> ("2010-01-01","2011-01-01" ),
                new ValueTuple<string, string> ("2011-01-01","2012-01-01" ),
                new ValueTuple<string, string> ("2012-01-01","2013-01-01" ),
                new ValueTuple<string, string> ("2013-01-01","2014-01-01" ),
                new ValueTuple<string, string> ("2014-01-01","2015-01-01" ),
                new ValueTuple<string, string> ("2015-01-01","2016-01-01" ),
                new ValueTuple<string, string> ("2016-01-01","2017-01-01" ),
                new ValueTuple<string, string> ("2017-01-01","2018-01-01" ),
                new ValueTuple<string, string> ("2018-01-01","2019-01-01" ),
                new ValueTuple<string, string> ("2019-01-01","2020-01-01" ),
                new ValueTuple<string, string> ("2020-01-01","2021-01-01" ),
                new ValueTuple<string, string> ("2021-01-01","2022-01-01" ),
                new ValueTuple<string, string> ("2022-01-01","2023-01-01" ),
                new ValueTuple<string, string> ("2023-01-01","2024-01-01" ),
                new ValueTuple<string, string> ("2024-01-01","2024-10-01" )
            ];

            foreach (var language in languages) {
                foreach (var date in dates) {
                    Log.Information($"Working with date range {date.from} : {date.to}, lang: '{language.name}'");
                    var client = new RestClient("https://api.github.com"); // options
                    client.AddDefaultHeaders(new Dictionary<string, string> { { "Authorization", "Bearer YOURTOKEN" }, { "X-GitHub-Api-Version", "2022-11-28" }, { "accept", "application/vnd.github+json" } });
                    var request = new RestRequest($"/search/repositories?q=language:{language.name}+created:{date.from}..{date.to}+sort:created-asc", Method.Get);
                    var response = client.Execute<Repos>(request);
                    if (response.StatusCode == System.Net.HttpStatusCode.OK && response.Data.items.Count > 0) {
                        Log.Information($"Got {response.Data.items.Count} projects.");
                        foreach (var item in response.Data.items) {
                            if (Enumerable.Range(5, 12).Contains(item.name.Length)) {
                                Log.Information($"Saving project: '{item.name}', created: {item.created_at}");
                                githubData.projectNames.Add(item.name);
                            }
                            var treesRequest = new RestRequest($"/repos/{item.owner.login}/{item.name}/git/trees/master?recursive=1", Method.Get);
                            var treesResponse = client.Execute<Trees>(treesRequest);
                            if (treesResponse.StatusCode == System.Net.HttpStatusCode.OK && treesResponse.Data.tree.Count > 0) {
                                foreach (var tree in treesResponse.Data.tree) {
                                    if (tree.type.Equals("blob") && tree.path.EndsWith($".{language.ext}") && Enumerable.Range(5, 16).Contains(Path.GetFileNameWithoutExtension(tree.path).Length)) {
                                        githubData.fileNames.Add(Path.GetFileNameWithoutExtension(tree.path));
                                        Log.Information($"Saved filename: '{Path.GetFileName(tree.path)}'");
                                    }
                                }
                            } else { Log.Information($"Files not found."); }
                        }
                    } else { Log.Information($"Projects not found."); }
                }
            }
            Log.Information($"Projects {githubData.projectNames.Count}, files: {githubData.fileNames.Count}");
            var str = JsonConvert.SerializeObject(githubData);
            File.WriteAllText(@"e:\\data.json", str);
        }
    }     
}
