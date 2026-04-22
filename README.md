# Hello Blazor Pages

This repository is a small, template-friendly starter for hosting a standalone Blazor WebAssembly app on GitHub Pages.

It intentionally keeps the app simple:

- `src/HelloBlazorPages` contains the Blazor WebAssembly app.
- `tests/HelloBlazorPages.Tests` contains a starter test project wired into the solution.
- `.github/workflows/ci.yml` runs restore, build, and test on pushes and pull requests.
- `.github/workflows/deploy-pages.yml` publishes the app and deploys it to GitHub Pages.

## Why this is different from the Microsoft sample

This repo borrows the GitHub Pages hosting idea from the Blazor samples, but it is not named the same and it does not reproduce the Xref Generator app. The goal here is to give you a clean "hello world" style starting point that can become your own template repository.

## Repository layout

The layout follows the common .NET convention of separating production code and tests:

```text
.
|-- .github/
|   `-- workflows/
|-- src/
|   `-- HelloBlazorPages/
`-- tests/
    `-- HelloBlazorPages.Tests/
```

## How deployment works

The GitHub Pages workflow does four important things:

1. Publishes the standalone Blazor WebAssembly app.
2. Rewrites the `<base href>` to match the repository name for project Pages sites.
3. Ships a `404.html` SPA fallback so client-side routes still resolve after refresh.
4. Uploads the prepared static site to GitHub Pages.

For a repository like `https://github.com/your-name/your-repo`, the deployed base path becomes `/your-repo/`.

For a user or organization site repository like `your-name.github.io`, the deployed base path stays `/`.

## First-time GitHub setup

In the repository settings on GitHub:

1. Open `Settings` > `Pages`.
2. Set the source to `GitHub Actions`.
3. Push to `main` or run the `Deploy Pages` workflow manually.

## Local development

```powershell
dotnet restore gh-pages.slnx
dotnet watch --project src/HelloBlazorPages run
```

## Local validation

```powershell
dotnet build gh-pages.slnx
dotnet test gh-pages.slnx
```

## Turning this into your own template

- Rename `HelloBlazorPages` to your preferred app name.
- Update the solution filename if you want a cleaner repo-specific name.
- Replace the home page content with your real site.
- Keep the deployment workflow unless you move away from GitHub Pages.
