// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace StableDiffusionWebUI.Client.Models
{
    /// <summary> Options. </summary>
    public partial class Options
    {
        /// <summary> Initializes a new instance of Options. </summary>
        internal Options()
        {
            RealesrganEnabledModels = new ChangeTrackingList<object>();
            RandomArtistCategories = new ChangeTrackingList<object>();
            HideSamplers = new ChangeTrackingList<object>();
            DisabledExtensions = new ChangeTrackingList<object>();
        }

        /// <summary> Initializes a new instance of Options. </summary>
        /// <param name="samplesSave"> Always save all generated images. </param>
        /// <param name="samplesFormat"> File format for images. </param>
        /// <param name="samplesFilenamePattern"> Images filename pattern. </param>
        /// <param name="saveImagesAddNumber"> Add number to filename when saving. </param>
        /// <param name="gridSave"> Always save all generated image grids. </param>
        /// <param name="gridFormat"> File format for grids. </param>
        /// <param name="gridExtendedFilename"> Add extended info (seed, prompt) to filename when saving grid. </param>
        /// <param name="gridOnlyIfMultiple"> Do not save grids consisting of one picture. </param>
        /// <param name="gridPreventEmptySpots"> Prevent empty spots in grid (when set to autodetect). </param>
        /// <param name="nRows"> Grid row count; use -1 for autodetect and 0 for it to be same as batch size. </param>
        /// <param name="enablePnginfo"> Save text information about generation parameters as chunks to png files. </param>
        /// <param name="saveTxt"> Create a text file next to every image with generation parameters. </param>
        /// <param name="saveImagesBeforeFaceRestoration"> Save a copy of image before doing face restoration. </param>
        /// <param name="saveImagesBeforeHighresFix"> Save a copy of image before applying highres fix. </param>
        /// <param name="saveImagesBeforeColorCorrection"> Save a copy of image before applying color correction to img2img results. </param>
        /// <param name="jpegQuality"> Quality for saved jpeg images. </param>
        /// <param name="exportFor4Chan"> If PNG image is larger than 4MB or any dimension is larger than 4000, downscale and save copy as JPG. </param>
        /// <param name="useOriginalNameBatch"> Use original name for output filename during batch process in extras tab. </param>
        /// <param name="saveSelectedOnly"> When using &apos;Save&apos; button, only save a single selected image. </param>
        /// <param name="doNotAddWatermark"> Do not add watermark to images. </param>
        /// <param name="outdirSamples"> Output directory for images; if empty, defaults to three directories below. </param>
        /// <param name="outdirTxt2ImgSamples"> Output directory for txt2img images. </param>
        /// <param name="outdirImg2ImgSamples"> Output directory for img2img images. </param>
        /// <param name="outdirExtrasSamples"> Output directory for images from extras tab. </param>
        /// <param name="outdirGrids"> Output directory for grids; if empty, defaults to two directories below. </param>
        /// <param name="outdirTxt2ImgGrids"> Output directory for txt2img grids. </param>
        /// <param name="outdirImg2ImgGrids"> Output directory for img2img grids. </param>
        /// <param name="outdirSave"> Directory for saving images using the Save button. </param>
        /// <param name="saveToDirs"> Save images to a subdirectory. </param>
        /// <param name="gridSaveToDirs"> Save grids to a subdirectory. </param>
        /// <param name="useSaveToDirsForUi"> When using &quot;Save&quot; button, save images to a subdirectory. </param>
        /// <param name="directoriesFilenamePattern"> Directory name pattern. </param>
        /// <param name="directoriesMaxPromptWords"> Max prompt words for [prompt_words] pattern. </param>
        /// <param name="esrganTile"> Tile size for ESRGAN upscalers. 0 = no tiling. </param>
        /// <param name="esrganTileOverlap"> Tile overlap, in pixels for ESRGAN upscalers. Low values = visible seam. </param>
        /// <param name="realesrganEnabledModels"> Select which Real-ESRGAN models to show in the web UI. (Requires restart). </param>
        /// <param name="swinTile"> Tile size for all SwinIR. </param>
        /// <param name="swinTileOverlap"> Tile overlap, in pixels for SwinIR. Low values = visible seam. </param>
        /// <param name="ldsrSteps"> LDSR processing steps. Lower = faster. </param>
        /// <param name="upscalerForImg2Img"> Upscaler for img2img. </param>
        /// <param name="useScaleLatentForHiresFix"> Upscale latent space image when doing hires. fix. </param>
        /// <param name="faceRestorationModel"> Face restoration model. </param>
        /// <param name="codeFormerWeight"> CodeFormer weight parameter; 0 = maximum effect; 1 = minimum effect. </param>
        /// <param name="faceRestorationUnload"> Move face restoration model from VRAM into RAM after processing. </param>
        /// <param name="memmonPollRate"> VRAM usage polls per second during generation. Set to 0 to disable. </param>
        /// <param name="samplesLogStdout"> Always print all generation info to standard output. </param>
        /// <param name="multipleTqdm"> Add a second progress bar to the console that shows progress for an entire job. </param>
        /// <param name="unloadModelsWhenTraining"> Move VAE and CLIP to RAM when training if possible. Saves VRAM. </param>
        /// <param name="shuffleTags"> Shuffleing tags by &apos;,&apos; when create texts. </param>
        /// <param name="tagDropOut"> Dropout tags when create texts. </param>
        /// <param name="saveOptimizerState"> Saves Optimizer state as separate *.optim file. Training can be resumed with HN itself and matching optim file. </param>
        /// <param name="datasetFilenameWordRegex"> Filename word regex. </param>
        /// <param name="datasetFilenameJoinString"> Filename join string. </param>
        /// <param name="trainingImageRepeatsPerEpoch"> Number of repeats for a single input image per epoch; used only for displaying epoch number. </param>
        /// <param name="trainingWriteCsvEvery"> Save an csv containing the loss to log directory every N steps, 0 to disable. </param>
        /// <param name="trainingXattentionOptimizations"> Use cross attention optimizations while training. </param>
        /// <param name="sdModelCheckpoint"> Stable Diffusion checkpoint. </param>
        /// <param name="sdCheckpointCache"> Checkpoints to cache in RAM. </param>
        /// <param name="sdVae"> SD VAE. </param>
        /// <param name="sdVaeAsDefault"> Ignore selected VAE for stable diffusion checkpoints that have their own .vae.pt next to them. </param>
        /// <param name="sdHypernetwork"> Hypernetwork. </param>
        /// <param name="sdHypernetworkStrength"> Hypernetwork strength. </param>
        /// <param name="inpaintingMaskWeight"> Inpainting conditioning mask strength. </param>
        /// <param name="img2ImgColorCorrection"> Apply color correction to img2img results to match original colors. </param>
        /// <param name="img2ImgFixSteps"> With img2img, do exactly the amount of steps the slider specifies (normally you&apos;d do less with less denoising). </param>
        /// <param name="enableQuantization"> Enable quantization in K samplers for sharper and cleaner results. This may change existing seeds. Requires restart to apply. </param>
        /// <param name="enableEmphasis"> Emphasis: use (text) to make model pay more attention to text and [text] to make it pay less attention. </param>
        /// <param name="useOldEmphasisImplementation"> Use old emphasis implementation. Can be useful to reproduce old seeds. </param>
        /// <param name="enableBatchSeeds"> Make K-diffusion samplers produce same images in a batch as when making a single image. </param>
        /// <param name="commaPaddingBacktrack"> Increase coherency by padding from the last comma within n tokens when using more than 75 tokens. </param>
        /// <param name="filterNsfw"> Filter NSFW content. </param>
        /// <param name="clipStopAtLastLayers"> Stop At last layers of CLIP model. </param>
        /// <param name="randomArtistCategories"> Allowed categories for random artists selection when using the Roll button. </param>
        /// <param name="interrogateKeepModelsInMemory"> Interrogate: keep models in VRAM. </param>
        /// <param name="interrogateUseBuiltinArtists"> Interrogate: use artists from artists.csv. </param>
        /// <param name="interrogateReturnRanks"> Interrogate: include ranks of model tags matches in results (Has no effect on caption-based interrogators). </param>
        /// <param name="interrogateClipNumBeams"> Interrogate: num_beams for BLIP. </param>
        /// <param name="interrogateClipMinLength"> Interrogate: minimum description length (excluding artists, etc..). </param>
        /// <param name="interrogateClipMaxLength"> Interrogate: maximum description length. </param>
        /// <param name="interrogateClipDictLimit"> CLIP: maximum number of lines in text file (0 = No limit). </param>
        /// <param name="interrogateDeepbooruScoreThreshold"> Interrogate: deepbooru score threshold. </param>
        /// <param name="deepbooruSortAlpha"> Interrogate: deepbooru sort alphabetically. </param>
        /// <param name="deepbooruUseSpaces"> use spaces for tags in deepbooru. </param>
        /// <param name="deepbooruEscape"> escape (\) brackets in deepbooru (so they are used as literal brackets and not for emphasis). </param>
        /// <param name="showProgressbar"> Show progressbar. </param>
        /// <param name="showProgressEveryNSteps"> Show image creation progress every N sampling steps. Set to 0 to disable. Set to -1 to show after completion of batch. </param>
        /// <param name="showProgressGrid"> Show previews of all images generated in a batch as a grid. </param>
        /// <param name="returnGrid"> Show grid in results for web. </param>
        /// <param name="doNotShowImages"> Do not show any images in results for web. </param>
        /// <param name="addModelHashToInfo"> Add model hash to generation information. </param>
        /// <param name="addModelNameToInfo"> Add model name to generation information. </param>
        /// <param name="disableWeightsAutoSwap"> When reading generation parameters from text into UI (from PNG info or pasted text), do not change the selected model/checkpoint. </param>
        /// <param name="sendSeed"> Send seed when sending prompt or image to other interface. </param>
        /// <param name="font"> Font for image grids that have text. </param>
        /// <param name="jsModalLightbox"> Enable full page image viewer. </param>
        /// <param name="jsModalLightboxInitiallyZoomed"> Show images zoomed in by default in full page image viewer. </param>
        /// <param name="showProgressInTitle"> Show generation progress in window title. </param>
        /// <param name="quicksettings"> Quicksettings list. </param>
        /// <param name="localization"> Localization (requires restart). </param>
        /// <param name="hideSamplers"> Hide samplers in user interface (requires restart). </param>
        /// <param name="etaDdim"> eta (noise multiplier) for DDIM. </param>
        /// <param name="etaAncestral"> eta (noise multiplier) for ancestral samplers. </param>
        /// <param name="ddimDiscretize"> img2img DDIM discretize. </param>
        /// <param name="sChurn"> sigma churn. </param>
        /// <param name="sTmin"> sigma tmin. </param>
        /// <param name="sNoise"> sigma noise. </param>
        /// <param name="etaNoiseSeedDelta"> Eta noise seed delta. </param>
        /// <param name="disabledExtensions"> Disable those extensions. </param>
        internal Options(bool? samplesSave, string samplesFormat, string samplesFilenamePattern, bool? saveImagesAddNumber, bool? gridSave, string gridFormat, bool? gridExtendedFilename, bool? gridOnlyIfMultiple, bool? gridPreventEmptySpots, float? nRows, bool? enablePnginfo, bool? saveTxt, bool? saveImagesBeforeFaceRestoration, bool? saveImagesBeforeHighresFix, bool? saveImagesBeforeColorCorrection, float? jpegQuality, bool? exportFor4Chan, bool? useOriginalNameBatch, bool? saveSelectedOnly, bool? doNotAddWatermark, string outdirSamples, string outdirTxt2ImgSamples, string outdirImg2ImgSamples, string outdirExtrasSamples, string outdirGrids, string outdirTxt2ImgGrids, string outdirImg2ImgGrids, string outdirSave, bool? saveToDirs, bool? gridSaveToDirs, bool? useSaveToDirsForUi, string directoriesFilenamePattern, float? directoriesMaxPromptWords, float? esrganTile, float? esrganTileOverlap, IReadOnlyList<object> realesrganEnabledModels, float? swinTile, float? swinTileOverlap, float? ldsrSteps, string upscalerForImg2Img, bool? useScaleLatentForHiresFix, string faceRestorationModel, float? codeFormerWeight, bool? faceRestorationUnload, float? memmonPollRate, bool? samplesLogStdout, bool? multipleTqdm, bool? unloadModelsWhenTraining, bool? shuffleTags, float? tagDropOut, bool? saveOptimizerState, string datasetFilenameWordRegex, string datasetFilenameJoinString, float? trainingImageRepeatsPerEpoch, float? trainingWriteCsvEvery, bool? trainingXattentionOptimizations, string sdModelCheckpoint, float? sdCheckpointCache, string sdVae, string sdVaeAsDefault, string sdHypernetwork, int? sdHypernetworkStrength, int? inpaintingMaskWeight, bool? img2ImgColorCorrection, bool? img2ImgFixSteps, bool? enableQuantization, bool? enableEmphasis, bool? useOldEmphasisImplementation, bool? enableBatchSeeds, float? commaPaddingBacktrack, bool? filterNsfw, float? clipStopAtLastLayers, IReadOnlyList<object> randomArtistCategories, bool? interrogateKeepModelsInMemory, bool? interrogateUseBuiltinArtists, bool? interrogateReturnRanks, float? interrogateClipNumBeams, float? interrogateClipMinLength, float? interrogateClipMaxLength, float? interrogateClipDictLimit, float? interrogateDeepbooruScoreThreshold, bool? deepbooruSortAlpha, bool? deepbooruUseSpaces, bool? deepbooruEscape, bool? showProgressbar, float? showProgressEveryNSteps, bool? showProgressGrid, bool? returnGrid, bool? doNotShowImages, bool? addModelHashToInfo, bool? addModelNameToInfo, bool? disableWeightsAutoSwap, bool? sendSeed, string font, bool? jsModalLightbox, bool? jsModalLightboxInitiallyZoomed, bool? showProgressInTitle, string quicksettings, string localization, IReadOnlyList<object> hideSamplers, int? etaDdim, int? etaAncestral, string ddimDiscretize, int? sChurn, int? sTmin, int? sNoise, float? etaNoiseSeedDelta, IReadOnlyList<object> disabledExtensions)
        {
            SamplesSave = samplesSave;
            SamplesFormat = samplesFormat;
            SamplesFilenamePattern = samplesFilenamePattern;
            SaveImagesAddNumber = saveImagesAddNumber;
            GridSave = gridSave;
            GridFormat = gridFormat;
            GridExtendedFilename = gridExtendedFilename;
            GridOnlyIfMultiple = gridOnlyIfMultiple;
            GridPreventEmptySpots = gridPreventEmptySpots;
            NRows = nRows;
            EnablePnginfo = enablePnginfo;
            SaveTxt = saveTxt;
            SaveImagesBeforeFaceRestoration = saveImagesBeforeFaceRestoration;
            SaveImagesBeforeHighresFix = saveImagesBeforeHighresFix;
            SaveImagesBeforeColorCorrection = saveImagesBeforeColorCorrection;
            JpegQuality = jpegQuality;
            ExportFor4Chan = exportFor4Chan;
            UseOriginalNameBatch = useOriginalNameBatch;
            SaveSelectedOnly = saveSelectedOnly;
            DoNotAddWatermark = doNotAddWatermark;
            OutdirSamples = outdirSamples;
            OutdirTxt2ImgSamples = outdirTxt2ImgSamples;
            OutdirImg2ImgSamples = outdirImg2ImgSamples;
            OutdirExtrasSamples = outdirExtrasSamples;
            OutdirGrids = outdirGrids;
            OutdirTxt2ImgGrids = outdirTxt2ImgGrids;
            OutdirImg2ImgGrids = outdirImg2ImgGrids;
            OutdirSave = outdirSave;
            SaveToDirs = saveToDirs;
            GridSaveToDirs = gridSaveToDirs;
            UseSaveToDirsForUi = useSaveToDirsForUi;
            DirectoriesFilenamePattern = directoriesFilenamePattern;
            DirectoriesMaxPromptWords = directoriesMaxPromptWords;
            EsrganTile = esrganTile;
            EsrganTileOverlap = esrganTileOverlap;
            RealesrganEnabledModels = realesrganEnabledModels;
            SwinTile = swinTile;
            SwinTileOverlap = swinTileOverlap;
            LdsrSteps = ldsrSteps;
            UpscalerForImg2Img = upscalerForImg2Img;
            UseScaleLatentForHiresFix = useScaleLatentForHiresFix;
            FaceRestorationModel = faceRestorationModel;
            CodeFormerWeight = codeFormerWeight;
            FaceRestorationUnload = faceRestorationUnload;
            MemmonPollRate = memmonPollRate;
            SamplesLogStdout = samplesLogStdout;
            MultipleTqdm = multipleTqdm;
            UnloadModelsWhenTraining = unloadModelsWhenTraining;
            ShuffleTags = shuffleTags;
            TagDropOut = tagDropOut;
            SaveOptimizerState = saveOptimizerState;
            DatasetFilenameWordRegex = datasetFilenameWordRegex;
            DatasetFilenameJoinString = datasetFilenameJoinString;
            TrainingImageRepeatsPerEpoch = trainingImageRepeatsPerEpoch;
            TrainingWriteCsvEvery = trainingWriteCsvEvery;
            TrainingXattentionOptimizations = trainingXattentionOptimizations;
            SdModelCheckpoint = sdModelCheckpoint;
            SdCheckpointCache = sdCheckpointCache;
            SdVae = sdVae;
            SdVaeAsDefault = sdVaeAsDefault;
            SdHypernetwork = sdHypernetwork;
            SdHypernetworkStrength = sdHypernetworkStrength;
            InpaintingMaskWeight = inpaintingMaskWeight;
            Img2ImgColorCorrection = img2ImgColorCorrection;
            Img2ImgFixSteps = img2ImgFixSteps;
            EnableQuantization = enableQuantization;
            EnableEmphasis = enableEmphasis;
            UseOldEmphasisImplementation = useOldEmphasisImplementation;
            EnableBatchSeeds = enableBatchSeeds;
            CommaPaddingBacktrack = commaPaddingBacktrack;
            FilterNsfw = filterNsfw;
            ClipStopAtLastLayers = clipStopAtLastLayers;
            RandomArtistCategories = randomArtistCategories;
            InterrogateKeepModelsInMemory = interrogateKeepModelsInMemory;
            InterrogateUseBuiltinArtists = interrogateUseBuiltinArtists;
            InterrogateReturnRanks = interrogateReturnRanks;
            InterrogateClipNumBeams = interrogateClipNumBeams;
            InterrogateClipMinLength = interrogateClipMinLength;
            InterrogateClipMaxLength = interrogateClipMaxLength;
            InterrogateClipDictLimit = interrogateClipDictLimit;
            InterrogateDeepbooruScoreThreshold = interrogateDeepbooruScoreThreshold;
            DeepbooruSortAlpha = deepbooruSortAlpha;
            DeepbooruUseSpaces = deepbooruUseSpaces;
            DeepbooruEscape = deepbooruEscape;
            ShowProgressbar = showProgressbar;
            ShowProgressEveryNSteps = showProgressEveryNSteps;
            ShowProgressGrid = showProgressGrid;
            ReturnGrid = returnGrid;
            DoNotShowImages = doNotShowImages;
            AddModelHashToInfo = addModelHashToInfo;
            AddModelNameToInfo = addModelNameToInfo;
            DisableWeightsAutoSwap = disableWeightsAutoSwap;
            SendSeed = sendSeed;
            Font = font;
            JsModalLightbox = jsModalLightbox;
            JsModalLightboxInitiallyZoomed = jsModalLightboxInitiallyZoomed;
            ShowProgressInTitle = showProgressInTitle;
            Quicksettings = quicksettings;
            Localization = localization;
            HideSamplers = hideSamplers;
            EtaDdim = etaDdim;
            EtaAncestral = etaAncestral;
            DdimDiscretize = ddimDiscretize;
            SChurn = sChurn;
            STmin = sTmin;
            SNoise = sNoise;
            EtaNoiseSeedDelta = etaNoiseSeedDelta;
            DisabledExtensions = disabledExtensions;
        }

        /// <summary> Always save all generated images. </summary>
        public bool? SamplesSave { get; }
        /// <summary> File format for images. </summary>
        public string SamplesFormat { get; }
        /// <summary> Images filename pattern. </summary>
        public string SamplesFilenamePattern { get; }
        /// <summary> Add number to filename when saving. </summary>
        public bool? SaveImagesAddNumber { get; }
        /// <summary> Always save all generated image grids. </summary>
        public bool? GridSave { get; }
        /// <summary> File format for grids. </summary>
        public string GridFormat { get; }
        /// <summary> Add extended info (seed, prompt) to filename when saving grid. </summary>
        public bool? GridExtendedFilename { get; }
        /// <summary> Do not save grids consisting of one picture. </summary>
        public bool? GridOnlyIfMultiple { get; }
        /// <summary> Prevent empty spots in grid (when set to autodetect). </summary>
        public bool? GridPreventEmptySpots { get; }
        /// <summary> Grid row count; use -1 for autodetect and 0 for it to be same as batch size. </summary>
        public float? NRows { get; }
        /// <summary> Save text information about generation parameters as chunks to png files. </summary>
        public bool? EnablePnginfo { get; }
        /// <summary> Create a text file next to every image with generation parameters. </summary>
        public bool? SaveTxt { get; }
        /// <summary> Save a copy of image before doing face restoration. </summary>
        public bool? SaveImagesBeforeFaceRestoration { get; }
        /// <summary> Save a copy of image before applying highres fix. </summary>
        public bool? SaveImagesBeforeHighresFix { get; }
        /// <summary> Save a copy of image before applying color correction to img2img results. </summary>
        public bool? SaveImagesBeforeColorCorrection { get; }
        /// <summary> Quality for saved jpeg images. </summary>
        public float? JpegQuality { get; }
        /// <summary> If PNG image is larger than 4MB or any dimension is larger than 4000, downscale and save copy as JPG. </summary>
        public bool? ExportFor4Chan { get; }
        /// <summary> Use original name for output filename during batch process in extras tab. </summary>
        public bool? UseOriginalNameBatch { get; }
        /// <summary> When using &apos;Save&apos; button, only save a single selected image. </summary>
        public bool? SaveSelectedOnly { get; }
        /// <summary> Do not add watermark to images. </summary>
        public bool? DoNotAddWatermark { get; }
        /// <summary> Output directory for images; if empty, defaults to three directories below. </summary>
        public string OutdirSamples { get; }
        /// <summary> Output directory for txt2img images. </summary>
        public string OutdirTxt2ImgSamples { get; }
        /// <summary> Output directory for img2img images. </summary>
        public string OutdirImg2ImgSamples { get; }
        /// <summary> Output directory for images from extras tab. </summary>
        public string OutdirExtrasSamples { get; }
        /// <summary> Output directory for grids; if empty, defaults to two directories below. </summary>
        public string OutdirGrids { get; }
        /// <summary> Output directory for txt2img grids. </summary>
        public string OutdirTxt2ImgGrids { get; }
        /// <summary> Output directory for img2img grids. </summary>
        public string OutdirImg2ImgGrids { get; }
        /// <summary> Directory for saving images using the Save button. </summary>
        public string OutdirSave { get; }
        /// <summary> Save images to a subdirectory. </summary>
        public bool? SaveToDirs { get; }
        /// <summary> Save grids to a subdirectory. </summary>
        public bool? GridSaveToDirs { get; }
        /// <summary> When using &quot;Save&quot; button, save images to a subdirectory. </summary>
        public bool? UseSaveToDirsForUi { get; }
        /// <summary> Directory name pattern. </summary>
        public string DirectoriesFilenamePattern { get; }
        /// <summary> Max prompt words for [prompt_words] pattern. </summary>
        public float? DirectoriesMaxPromptWords { get; }
        /// <summary> Tile size for ESRGAN upscalers. 0 = no tiling. </summary>
        public float? EsrganTile { get; }
        /// <summary> Tile overlap, in pixels for ESRGAN upscalers. Low values = visible seam. </summary>
        public float? EsrganTileOverlap { get; }
        /// <summary> Select which Real-ESRGAN models to show in the web UI. (Requires restart). </summary>
        public IReadOnlyList<object> RealesrganEnabledModels { get; }
        /// <summary> Tile size for all SwinIR. </summary>
        public float? SwinTile { get; }
        /// <summary> Tile overlap, in pixels for SwinIR. Low values = visible seam. </summary>
        public float? SwinTileOverlap { get; }
        /// <summary> LDSR processing steps. Lower = faster. </summary>
        public float? LdsrSteps { get; }
        /// <summary> Upscaler for img2img. </summary>
        public string UpscalerForImg2Img { get; }
        /// <summary> Upscale latent space image when doing hires. fix. </summary>
        public bool? UseScaleLatentForHiresFix { get; }
        /// <summary> Face restoration model. </summary>
        public string FaceRestorationModel { get; }
        /// <summary> CodeFormer weight parameter; 0 = maximum effect; 1 = minimum effect. </summary>
        public float? CodeFormerWeight { get; }
        /// <summary> Move face restoration model from VRAM into RAM after processing. </summary>
        public bool? FaceRestorationUnload { get; }
        /// <summary> VRAM usage polls per second during generation. Set to 0 to disable. </summary>
        public float? MemmonPollRate { get; }
        /// <summary> Always print all generation info to standard output. </summary>
        public bool? SamplesLogStdout { get; }
        /// <summary> Add a second progress bar to the console that shows progress for an entire job. </summary>
        public bool? MultipleTqdm { get; }
        /// <summary> Move VAE and CLIP to RAM when training if possible. Saves VRAM. </summary>
        public bool? UnloadModelsWhenTraining { get; }
        /// <summary> Shuffleing tags by &apos;,&apos; when create texts. </summary>
        public bool? ShuffleTags { get; }
        /// <summary> Dropout tags when create texts. </summary>
        public float? TagDropOut { get; }
        /// <summary> Saves Optimizer state as separate *.optim file. Training can be resumed with HN itself and matching optim file. </summary>
        public bool? SaveOptimizerState { get; }
        /// <summary> Filename word regex. </summary>
        public string DatasetFilenameWordRegex { get; }
        /// <summary> Filename join string. </summary>
        public string DatasetFilenameJoinString { get; }
        /// <summary> Number of repeats for a single input image per epoch; used only for displaying epoch number. </summary>
        public float? TrainingImageRepeatsPerEpoch { get; }
        /// <summary> Save an csv containing the loss to log directory every N steps, 0 to disable. </summary>
        public float? TrainingWriteCsvEvery { get; }
        /// <summary> Use cross attention optimizations while training. </summary>
        public bool? TrainingXattentionOptimizations { get; }
        /// <summary> Stable Diffusion checkpoint. </summary>
        public string SdModelCheckpoint { get; }
        /// <summary> Checkpoints to cache in RAM. </summary>
        public float? SdCheckpointCache { get; }
        /// <summary> SD VAE. </summary>
        public string SdVae { get; }
        /// <summary> Ignore selected VAE for stable diffusion checkpoints that have their own .vae.pt next to them. </summary>
        public string SdVaeAsDefault { get; }
        /// <summary> Hypernetwork. </summary>
        public string SdHypernetwork { get; }
        /// <summary> Hypernetwork strength. </summary>
        public int? SdHypernetworkStrength { get; }
        /// <summary> Inpainting conditioning mask strength. </summary>
        public int? InpaintingMaskWeight { get; }
        /// <summary> Apply color correction to img2img results to match original colors. </summary>
        public bool? Img2ImgColorCorrection { get; }
        /// <summary> With img2img, do exactly the amount of steps the slider specifies (normally you&apos;d do less with less denoising). </summary>
        public bool? Img2ImgFixSteps { get; }
        /// <summary> Enable quantization in K samplers for sharper and cleaner results. This may change existing seeds. Requires restart to apply. </summary>
        public bool? EnableQuantization { get; }
        /// <summary> Emphasis: use (text) to make model pay more attention to text and [text] to make it pay less attention. </summary>
        public bool? EnableEmphasis { get; }
        /// <summary> Use old emphasis implementation. Can be useful to reproduce old seeds. </summary>
        public bool? UseOldEmphasisImplementation { get; }
        /// <summary> Make K-diffusion samplers produce same images in a batch as when making a single image. </summary>
        public bool? EnableBatchSeeds { get; }
        /// <summary> Increase coherency by padding from the last comma within n tokens when using more than 75 tokens. </summary>
        public float? CommaPaddingBacktrack { get; }
        /// <summary> Filter NSFW content. </summary>
        public bool? FilterNsfw { get; }
        /// <summary> Stop At last layers of CLIP model. </summary>
        public float? ClipStopAtLastLayers { get; }
        /// <summary> Allowed categories for random artists selection when using the Roll button. </summary>
        public IReadOnlyList<object> RandomArtistCategories { get; }
        /// <summary> Interrogate: keep models in VRAM. </summary>
        public bool? InterrogateKeepModelsInMemory { get; }
        /// <summary> Interrogate: use artists from artists.csv. </summary>
        public bool? InterrogateUseBuiltinArtists { get; }
        /// <summary> Interrogate: include ranks of model tags matches in results (Has no effect on caption-based interrogators). </summary>
        public bool? InterrogateReturnRanks { get; }
        /// <summary> Interrogate: num_beams for BLIP. </summary>
        public float? InterrogateClipNumBeams { get; }
        /// <summary> Interrogate: minimum description length (excluding artists, etc..). </summary>
        public float? InterrogateClipMinLength { get; }
        /// <summary> Interrogate: maximum description length. </summary>
        public float? InterrogateClipMaxLength { get; }
        /// <summary> CLIP: maximum number of lines in text file (0 = No limit). </summary>
        public float? InterrogateClipDictLimit { get; }
        /// <summary> Interrogate: deepbooru score threshold. </summary>
        public float? InterrogateDeepbooruScoreThreshold { get; }
        /// <summary> Interrogate: deepbooru sort alphabetically. </summary>
        public bool? DeepbooruSortAlpha { get; }
        /// <summary> use spaces for tags in deepbooru. </summary>
        public bool? DeepbooruUseSpaces { get; }
        /// <summary> escape (\) brackets in deepbooru (so they are used as literal brackets and not for emphasis). </summary>
        public bool? DeepbooruEscape { get; }
        /// <summary> Show progressbar. </summary>
        public bool? ShowProgressbar { get; }
        /// <summary> Show image creation progress every N sampling steps. Set to 0 to disable. Set to -1 to show after completion of batch. </summary>
        public float? ShowProgressEveryNSteps { get; }
        /// <summary> Show previews of all images generated in a batch as a grid. </summary>
        public bool? ShowProgressGrid { get; }
        /// <summary> Show grid in results for web. </summary>
        public bool? ReturnGrid { get; }
        /// <summary> Do not show any images in results for web. </summary>
        public bool? DoNotShowImages { get; }
        /// <summary> Add model hash to generation information. </summary>
        public bool? AddModelHashToInfo { get; }
        /// <summary> Add model name to generation information. </summary>
        public bool? AddModelNameToInfo { get; }
        /// <summary> When reading generation parameters from text into UI (from PNG info or pasted text), do not change the selected model/checkpoint. </summary>
        public bool? DisableWeightsAutoSwap { get; }
        /// <summary> Send seed when sending prompt or image to other interface. </summary>
        public bool? SendSeed { get; }
        /// <summary> Font for image grids that have text. </summary>
        public string Font { get; }
        /// <summary> Enable full page image viewer. </summary>
        public bool? JsModalLightbox { get; }
        /// <summary> Show images zoomed in by default in full page image viewer. </summary>
        public bool? JsModalLightboxInitiallyZoomed { get; }
        /// <summary> Show generation progress in window title. </summary>
        public bool? ShowProgressInTitle { get; }
        /// <summary> Quicksettings list. </summary>
        public string Quicksettings { get; }
        /// <summary> Localization (requires restart). </summary>
        public string Localization { get; }
        /// <summary> Hide samplers in user interface (requires restart). </summary>
        public IReadOnlyList<object> HideSamplers { get; }
        /// <summary> eta (noise multiplier) for DDIM. </summary>
        public int? EtaDdim { get; }
        /// <summary> eta (noise multiplier) for ancestral samplers. </summary>
        public int? EtaAncestral { get; }
        /// <summary> img2img DDIM discretize. </summary>
        public string DdimDiscretize { get; }
        /// <summary> sigma churn. </summary>
        public int? SChurn { get; }
        /// <summary> sigma tmin. </summary>
        public int? STmin { get; }
        /// <summary> sigma noise. </summary>
        public int? SNoise { get; }
        /// <summary> Eta noise seed delta. </summary>
        public float? EtaNoiseSeedDelta { get; }
        /// <summary> Disable those extensions. </summary>
        public IReadOnlyList<object> DisabledExtensions { get; }
    }
}