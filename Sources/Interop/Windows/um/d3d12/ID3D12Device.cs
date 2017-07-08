// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License MIT. See License.md in the repository root for more information.

// Ported from um\d3d12.h in the Windows SDK for Windows 10.0.15063.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Security;

namespace TerraFX.Interop
{
    [Guid("189819F1-1DB6-4B57-BE54-1821339B85F7")]
    unsafe public /* blittable */ struct ID3D12Device
    {
        #region Fields
        public readonly void* /* Vtbl* */ lpVtbl;
        #endregion

        #region Delegates
        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate UINT GetNodeCount(
            [In] ID3D12Device* This
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateCommandQueue(
            [In] ID3D12Device* This,
            [In] D3D12_COMMAND_QUEUE_DESC* pDesc,
            [In] REFIID riid,
            [Out] void** ppCommandQueue
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateCommandAllocator(
            [In] ID3D12Device* This,
            [In] D3D12_COMMAND_LIST_TYPE Type,
            [In] REFIID riid,
            [Out] void** ppCommandAllocator
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateGraphicsPipelineState(
            [In] ID3D12Device* This,
            [In] D3D12_GRAPHICS_PIPELINE_STATE_DESC* pDesc,
            [In] REFIID riid,
            [Out] void** ppPipelineState
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateComputePipelineState(
            [In] ID3D12Device* This,
            [In] D3D12_COMPUTE_PIPELINE_STATE_DESC* pDesc,
            [In] REFIID riid,
            [Out] void** ppPipelineState
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateCommandList(
            [In] ID3D12Device* This,
            [In] UINT NodeMask,
            [In] D3D12_COMMAND_LIST_TYPE Type,
            [In] ID3D12CommandAllocator* pCommandAllocator,
            [In, Optional] ID3D12PipelineState* pInitialState,
            [In] REFIID riid,
            [Out] void** ppCommandList
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CheckFeatureSupport(
            [In] ID3D12Device* This,
            [In] D3D12_FEATURE Feature,
            [In, Out] void* pFeatureSupportData,
            [In] UINT FeatureSupportDataSize
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateDescriptorHeap(
            [In] ID3D12Device* This,
            [In] D3D12_DESCRIPTOR_HEAP_DESC* pDescriptorHeapDesc,
            [In] REFIID riid,
            [Out] void** ppvHeap
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate UINT GetDescriptorHandleIncrementSize(
            [In] ID3D12Device* This,
            [In] D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapType
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateRootSignature(
            [In] ID3D12Device* This,
            [In] UINT NodeMask,
            [In] /* readonly */ void* pBlobWithRootSignature,
            [In] SIZE_T blobLengthInBytes,
            [In] REFIID riid,
            [Out] void** ppvRootSignature
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void CreateConstantBufferView(
            [In] ID3D12Device* This,
            [In, Optional] /* readonly */ D3D12_CONSTANT_BUFFER_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void CreateShaderResourceView(
            [In] ID3D12Device* This,
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] /* readonly */ D3D12_SHADER_RESOURCE_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void CreateUnorderedAccessView(
            [In] ID3D12Device* This,
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] ID3D12Resource* pCounterResource,
            [In, Optional] /* readonly */ D3D12_UNORDERED_ACCESS_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void CreateRenderTargetView(
            [In] ID3D12Device* This,
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] /* readonly */ D3D12_RENDER_TARGET_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void CreateDepthStencilView(
            [In] ID3D12Device* This,
            [In, Optional] ID3D12Resource* pResource,
            [In, Optional] /* readonly */ D3D12_DEPTH_STENCIL_VIEW_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void CreateSampler(
            [In] ID3D12Device* This,
            [In] /* readonly */ D3D12_SAMPLER_DESC* pDesc,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptor
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void CopyDescriptors(
            [In] ID3D12Device* This,
            [In] UINT NumDestDescriptorRanges,
            [In] /* readonly */ D3D12_CPU_DESCRIPTOR_HANDLE* pDestDescriptorRangeStarts,
            [In, Optional] /* readonly */ UINT* pDestDescriptorRangeSizes,
            [In] UINT NumSrcDescriptorRanges,
            [In] /* readonly */ D3D12_CPU_DESCRIPTOR_HANDLE* pSrcDescriptorRangeStarts,
            [In, Optional] /* readonly */ UINT* pSrcDescriptorRangeSizes,
            [In] D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void CopyDescriptorsSimple(
            [In] ID3D12Device* This,
            [In] UINT NumDescriptors,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE DestDescriptorRangeStart,
            [In] D3D12_CPU_DESCRIPTOR_HANDLE SrcDescriptorRangeStart,
            [In] D3D12_DESCRIPTOR_HEAP_TYPE DescriptorHeapsType
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D3D12_RESOURCE_ALLOCATION_INFO GetResourceAllocationInfo(
            [In] ID3D12Device* This,
            [In] UINT visibleMask,
            [In] UINT numResourceDescs,
            [In] /* readonly */ D3D12_RESOURCE_DESC* pResourceDescs
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate D3D12_HEAP_PROPERTIES GetCustomHeapProperties(
            [In] ID3D12Device* This,
            [In] UINT NodeMask,
            [In] D3D12_HEAP_TYPE heapType
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateCommittedResource(
            [In] ID3D12Device* This,
            [In] /* readonly */ D3D12_HEAP_PROPERTIES* pHeapProperties,
            [In] D3D12_HEAP_FLAGS HeapFlags,
            [In] /* readonly */ D3D12_RESOURCE_DESC* pDesc,
            [In] D3D12_RESOURCE_STATES InitialResourceState,
            [In, Optional] /* readonly */ D3D12_CLEAR_VALUE* pOptimizedClearValue,
            [In] REFIID riidResource,
            [Out, Optional] void** ppvResource
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateHeap(
            [In] ID3D12Device* This,
            [In] /* readonly */ D3D12_HEAP_DESC* pDesc,
            [In] REFIID riid,
            [Out, Optional] void** ppvHeap
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreatePlacedResource(
            [In] ID3D12Device* This,
            [In] ID3D12Heap* pHeap,
            [In] UINT64 HeapOffset,
            [In] /* readonly */ D3D12_RESOURCE_DESC* pDesc,
            [In] D3D12_RESOURCE_STATES InitialState,
            [In, Optional] /* readonly */ D3D12_CLEAR_VALUE* pOptimizedClearValue,
            [In] REFIID riid,
            [Out, Optional] void** ppvResource
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateReservedResource(
            [In] ID3D12Device* This,
            [In] /* readonly */ D3D12_RESOURCE_DESC* pDesc,
            [In] D3D12_RESOURCE_STATES InitialState,
            [In, Optional] /* readonly */ D3D12_CLEAR_VALUE* pOptimizedClearValue,
            [In] REFIID riid,
            [Out, Optional] void** ppvResource
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateSharedHandle(
            [In] ID3D12Device* This,
            [In] ID3D12DeviceChild* pObject,
            [In, Optional] /* readonly */ SECURITY_ATTRIBUTES* pAttributes,
            [In] DWORD Access,
            [In, Optional] LPCWSTR Name,
            [Out] HANDLE* pHandle
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT OpenSharedHandle(
            [In] ID3D12Device* This,
            [In] HANDLE NTHandle,
            [In] REFIID riid,
            [Out, Optional] void** ppvObj
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT OpenSharedHandleByName(
            [In] ID3D12Device* This,
            [In] LPCWSTR Name,
            [In] DWORD Access,
            [Out] HANDLE* pNTHandle
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT MakeResident(
            [In] ID3D12Device* This,
            [In] UINT NumObjects,
            [In] /* readonly */ ID3D12Pageable** ppObjects
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT Evict(
            [In] ID3D12Device* This,
            [In] UINT NumObjects,
            [In] /* readonly */ ID3D12Pageable** ppObjects
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateFence(
            [In] ID3D12Device* This,
            [In] UINT64 InitialValue,
            [In] D3D12_FENCE_FLAGS Flags,
            [In] REFIID riid,
            [Out] void** ppFence
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT GetDeviceRemovedReason(
            [In] ID3D12Device* This
        
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void GetCopyableFootprints(
            [In] ID3D12Device* This,
            [In] /* readonly */ D3D12_RESOURCE_DESC* pResourceDesc,
            [In] UINT FirstSubresource,
            [In] UINT NumSubresources,
            [In] UINT64 BaseOffset,
            [Out, Optional] D3D12_PLACED_SUBRESOURCE_FOOTPRINT* pLayouts,
            [Out, Optional] UINT* pNumRows,
            [Out, Optional] UINT64* pRowSizeInBytes,
            [Out, Optional] UINT64* pTotalBytes
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateQueryHeap(
            [In] ID3D12Device* This,
            [In] /* readonly */ D3D12_QUERY_HEAP_DESC* pDesc,
            [In] REFIID riid,
            [Out, Optional] void** ppvHeap
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT SetStablePowerState(
            [In] ID3D12Device* This,
            [In] BOOL Enable
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate HRESULT CreateCommandSignature(
            [In] ID3D12Device* This,
            [In] /* readonly */ D3D12_COMMAND_SIGNATURE_DESC* pDesc,
            [In, Optional] ID3D12RootSignature* pRootSignature,
            [In] REFIID riid,
            [Out, Optional] void** ppvCommandSignature
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate void GetResourceTiling(
            [In] ID3D12Device* This,
            [In] ID3D12Resource* pTiledResource,
            [Out, Optional] UINT* pNumTilesForEntireResource,
            [Out, Optional] D3D12_PACKED_MIP_INFO* pPackedMipDesc,
            [Out, Optional] D3D12_TILE_SHAPE* pStandardTileShapeForNonPackedMips,
            [In, Out, Optional] UINT* pNumSubresourceTilings,
            [In] UINT FirstSubresourceTilingToGet,
            [Out] D3D12_SUBRESOURCE_TILING* pSubresourceTilingsForNonPackedMips
        );

        [SuppressUnmanagedCodeSecurity]
        [UnmanagedFunctionPointer(CallingConvention.ThisCall, BestFitMapping = false, CharSet = CharSet.Unicode, SetLastError = false, ThrowOnUnmappableChar = false)]
        public /* static */ delegate LUID GetAdapterLuid(
            [In] ID3D12Device* This
        );
        #endregion

        #region Structs
        public /* blittable */ struct Vtbl
        {
            #region Fields
            public ID3D12Object.Vtbl BaseVtbl;

            public GetNodeCount GetNodeCount;

            public CreateCommandQueue CreateCommandQueue;

            public CreateCommandAllocator CreateCommandAllocator;

            public CreateGraphicsPipelineState CreateGraphicsPipelineState;

            public CreateComputePipelineState CreateComputePipelineState;

            public CreateCommandList CreateCommandList;

            public CheckFeatureSupport CheckFeatureSupport;

            public CreateDescriptorHeap CreateDescriptorHeap;

            public GetDescriptorHandleIncrementSize GetDescriptorHandleIncrementSize;

            public CreateRootSignature CreateRootSignature;

            public CreateConstantBufferView CreateConstantBufferView;

            public CreateShaderResourceView CreateShaderResourceView;

            public CreateUnorderedAccessView CreateUnorderedAccessView;

            public CreateRenderTargetView CreateRenderTargetView;

            public CreateDepthStencilView CreateDepthStencilView;

            public CreateSampler CreateSampler;

            public CopyDescriptors CopyDescriptors;

            public CopyDescriptorsSimple CopyDescriptorsSimple;

            public GetResourceAllocationInfo GetResourceAllocationInfo;

            public GetCustomHeapProperties GetCustomHeapProperties;

            public CreateCommittedResource CreateCommittedResource;

            public CreateHeap CreateHeap;

            public CreatePlacedResource CreatePlacedResource;

            public CreateReservedResource CreateReservedResource;

            public CreateSharedHandle CreateSharedHandle;

            public OpenSharedHandle OpenSharedHandle;

            public OpenSharedHandleByName OpenSharedHandleByName;

            public MakeResident MakeResident;

            public Evict Evict;

            public CreateFence CreateFence;

            public GetDeviceRemovedReason GetDeviceRemovedReason;

            public GetCopyableFootprints GetCopyableFootprints;

            public CreateQueryHeap CreateQueryHeap;

            public SetStablePowerState SetStablePowerState;

            public CreateCommandSignature CreateCommandSignature;

            public GetResourceTiling GetResourceTiling;

            public GetAdapterLuid GetAdapterLuid;
            #endregion
        }
        #endregion
    }
}