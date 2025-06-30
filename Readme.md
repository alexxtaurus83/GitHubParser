# GitHub Repository & File Name Scraper

This is a .NET console application designed to scrape data from GitHub. It systematically searches for repositories based on programming language and creation date, then drills down into those repositories to collect unique source file names. The final aggregated data is saved to a local JSON file.

This tool is useful for gathering large datasets of repository and file names for research, analysis, or generating datasets for machine learning models.

## How It Works

The application performs the following steps:

1.  **Iterates through Targets**: It loops through a predefined list of programming languages (e.g., C#, Java, Python) and a series of date ranges (e.g., 2010-2011, 2011-2012, etc.).
2.  **Searches Repositories**: For each language and date combination, it queries the GitHub REST API to find a list of matching public repositories.
3.  **Filters Repositories**: It applies a basic filter to save only repository names that fall within a specific length range.
4.  **Fetches File Trees**: For each valid repository, it makes another API call to fetch its file tree recursively.
5.  **Extracts File Names**: It processes the file tree, looking for files (`blobs`) that match the current programming language's extension (e.g., `.cs`, `.java`). It then filters these by filename length.
6.  **Stores Unique Names**: It adds the qualifying repository names and file names (without extension) to two separate `HashSet` collections to ensure the final lists are unique.
7.  **Saves Output**: Once all iterations are complete, it serializes the collected data into a single JSON object and writes it to a file.