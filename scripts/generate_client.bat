SET SCRIPT_PATH=%~dp0
SET LIBRARY_NAME=StableDiffusionWebUI.Client
autorest --csharp  --public-clients=false --output-folder="%SCRIPT_PATH%..\src\%LIBRARY_NAME%\generated" --title="Stable Diffusion WebUI Client" --library-name="%LIBRARY_NAME%" --namespace="%LIBRARY_NAME%" --generation1-convenience-client --v3 --input-file="%SCRIPT_PATH%..\openapi\openapi.json"