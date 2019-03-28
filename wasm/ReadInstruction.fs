// this file is automatically generated
module wasm.parse
    open wasm.buffer
    open wasm.instr
    let read_instruction (br: BinaryWasmStream) =
        let b1 = br.ReadByte()
        match b1 with
        | 0xfcuy ->
            let b2 = br.ReadByte()
            match b2 with
            | 0x00uy -> I32TruncSatF32S
            | 0x01uy -> I32TruncSatF32U
            | 0x02uy -> I32TruncSatF64S
            | 0x03uy -> I32TruncSatF64U
            | 0x04uy -> I64TruncSatF32S
            | 0x05uy -> I64TruncSatF32U
            | 0x06uy -> I64TruncSatF64S
            | 0x07uy -> I64TruncSatF64U
            | 0x08uy -> MemoryInit
            | 0x09uy -> DataDrop
            | 0x0auy -> MemoryCopy
            | 0x0buy -> MemoryFill
            | 0x0cuy -> TableInit
            | 0x0duy -> ElemDrop
            | 0x0euy -> TableCopy
            | 0x0fuy -> TableGrow
            | 0x10uy -> TableSize
            | _      -> failwith "todo"
        | 0xfduy ->
            let b2 = br.ReadByte()
            match b2 with
            | 0x00uy -> V128Load
            | 0x01uy -> V128Store
            | 0x02uy -> V128Const
            | 0x03uy -> V8X16Shuffle
            | 0x04uy -> I8X16Splat
            | 0x05uy -> I8X16ExtractLaneS
            | 0x06uy -> I8X16ExtractLaneU
            | 0x07uy -> I8X16ReplaceLane
            | 0x08uy -> I16X8Splat
            | 0x09uy -> I16X8ExtractLaneS
            | 0x0auy -> I16X8ExtractLaneU
            | 0x0buy -> I16X8ReplaceLane
            | 0x0cuy -> I32X4Splat
            | 0x0duy -> I32X4ExtractLane
            | 0x0euy -> I32X4ReplaceLane
            | 0x0fuy -> I64X2Splat
            | 0x10uy -> I64X2ExtractLane
            | 0x11uy -> I64X2ReplaceLane
            | 0x12uy -> F32X4Splat
            | 0x13uy -> F32X4ExtractLane
            | 0x14uy -> F32X4ReplaceLane
            | 0x15uy -> F64X2Splat
            | 0x16uy -> F64X2ExtractLane
            | 0x17uy -> F64X2ReplaceLane
            | 0x18uy -> I8X16Eq
            | 0x19uy -> I8X16Ne
            | 0x1auy -> I8X16LtS
            | 0x1buy -> I8X16LtU
            | 0x1cuy -> I8X16GtS
            | 0x1duy -> I8X16GtU
            | 0x1euy -> I8X16LeS
            | 0x1fuy -> I8X16LeU
            | 0x20uy -> I8X16GeS
            | 0x21uy -> I8X16GeU
            | 0x22uy -> I16X8Eq
            | 0x23uy -> I16X8Ne
            | 0x24uy -> I16X8LtS
            | 0x25uy -> I16X8LtU
            | 0x26uy -> I16X8GtS
            | 0x27uy -> I16X8GtU
            | 0x28uy -> I16X8LeS
            | 0x29uy -> I16X8LeU
            | 0x2auy -> I16X8GeS
            | 0x2buy -> I16X8GeU
            | 0x2cuy -> I32X4Eq
            | 0x2duy -> I32X4Ne
            | 0x2euy -> I32X4LtS
            | 0x2fuy -> I32X4LtU
            | 0x30uy -> I32X4GtS
            | 0x31uy -> I32X4GtU
            | 0x32uy -> I32X4LeS
            | 0x33uy -> I32X4LeU
            | 0x34uy -> I32X4GeS
            | 0x35uy -> I32X4GeU
            | 0x40uy -> F32X4Eq
            | 0x41uy -> F32X4Ne
            | 0x42uy -> F32X4Lt
            | 0x43uy -> F32X4Gt
            | 0x44uy -> F32X4Le
            | 0x45uy -> F32X4Ge
            | 0x46uy -> F64X2Eq
            | 0x47uy -> F64X2Ne
            | 0x48uy -> F64X2Lt
            | 0x49uy -> F64X2Gt
            | 0x4auy -> F64X2Le
            | 0x4buy -> F64X2Ge
            | 0x4cuy -> V128Not
            | 0x4duy -> V128And
            | 0x4euy -> V128Or
            | 0x4fuy -> V128Xor
            | 0x50uy -> V128BitSelect
            | 0x51uy -> I8X16Neg
            | 0x52uy -> I8X16AnyTrue
            | 0x53uy -> I8X16AllTrue
            | 0x54uy -> I8X16Shl
            | 0x55uy -> I8X16ShrS
            | 0x56uy -> I8X16ShrU
            | 0x57uy -> I8X16Add
            | 0x58uy -> I8X16AddSaturateS
            | 0x59uy -> I8X16AddSaturateU
            | 0x5auy -> I8X16Sub
            | 0x5buy -> I8X16SubSaturateS
            | 0x5cuy -> I8X16SubSaturateU
            | 0x5duy -> I8X16Mul
            | 0x62uy -> I16X8Neg
            | 0x63uy -> I16X8AnyTrue
            | 0x64uy -> I16X8AllTrue
            | 0x65uy -> I16X8Shl
            | 0x66uy -> I16X8ShrS
            | 0x67uy -> I16X8ShrU
            | 0x68uy -> I16X8Add
            | 0x69uy -> I16X8AddSaturateS
            | 0x6auy -> I16X8AddSaturateU
            | 0x6buy -> I16X8Sub
            | 0x6cuy -> I16X8SubSaturateS
            | 0x6duy -> I16X8SubSaturateU
            | 0x6euy -> I16X8Mul
            | 0x73uy -> I32X4Neg
            | 0x74uy -> I32X4AnyTrue
            | 0x75uy -> I32X4AllTrue
            | 0x76uy -> I32X4Shl
            | 0x77uy -> I32X4ShrS
            | 0x78uy -> I32X4ShrU
            | 0x79uy -> I32X4Add
            | 0x7cuy -> I32X4Sub
            | 0x7fuy -> I32X4Mul
            | 0x84uy -> I64X2Neg
            | 0x85uy -> I64X2AnyTrue
            | 0x86uy -> I64X2AllTrue
            | 0x87uy -> I64X2Shl
            | 0x88uy -> I64X2ShrS
            | 0x89uy -> I64X2ShrU
            | 0x8auy -> I64X2Add
            | 0x8duy -> I64X2Sub
            | 0x95uy -> F32X4Abs
            | 0x96uy -> F32X4Neg
            | 0x97uy -> F32X4Sqrt
            | 0x9auy -> F32X4Add
            | 0x9buy -> F32X4Sub
            | 0x9cuy -> F32X4Mul
            | 0x9duy -> F32X4Div
            | 0x9euy -> F32X4Min
            | 0x9fuy -> F32X4Max
            | 0xa0uy -> F64X2Abs
            | 0xa1uy -> F64X2Neg
            | 0xa2uy -> F64X2Sqrt
            | 0xa5uy -> F64X2Add
            | 0xa6uy -> F64X2Sub
            | 0xa7uy -> F64X2Mul
            | 0xa8uy -> F64X2Div
            | 0xa9uy -> F64X2Min
            | 0xaauy -> F64X2Max
            | 0xabuy -> I32X4TruncSatF32X4S
            | 0xacuy -> I32X4TruncSatF32X4U
            | 0xaduy -> I64X2TruncSatF64X2S
            | 0xaeuy -> I64X2TruncSatF64X2U
            | 0xafuy -> F32X4ConvertI32X4S
            | 0xb0uy -> F32X4ConvertI32X4U
            | 0xb1uy -> F64X2ConvertI64X2S
            | 0xb2uy -> F64X2ConvertI64X2U
            | _      -> failwith "todo"
        | 0xfeuy ->
            let b2 = br.ReadByte()
            match b2 with
            | 0x00uy -> AtomicNotify
            | 0x01uy -> I32AtomicWait
            | 0x02uy -> I64AtomicWait
            | 0x10uy -> I32AtomicLoad
            | 0x11uy -> I64AtomicLoad
            | 0x12uy -> I32AtomicLoad8U
            | 0x13uy -> I32AtomicLoad16U
            | 0x14uy -> I64AtomicLoad8U
            | 0x15uy -> I64AtomicLoad16U
            | 0x16uy -> I64AtomicLoad32U
            | 0x17uy -> I32AtomicStore
            | 0x18uy -> I64AtomicStore
            | 0x19uy -> I32AtomicStore8
            | 0x1auy -> I32AtomicStore16
            | 0x1buy -> I64AtomicStore8
            | 0x1cuy -> I64AtomicStore16
            | 0x1duy -> I64AtomicStore32
            | 0x1euy -> I32AtomicRmwAdd
            | 0x1fuy -> I64AtomicRmwAdd
            | 0x20uy -> I32AtomicRmw8AddU
            | 0x21uy -> I32AtomicRmw16AddU
            | 0x22uy -> I64AtomicRmw8AddU
            | 0x23uy -> I64AtomicRmw16AddU
            | 0x24uy -> I64AtomicRmw32AddU
            | 0x25uy -> I32AtomicRmwSub
            | 0x26uy -> I64AtomicRmwSub
            | 0x27uy -> I32AtomicRmw8SubU
            | 0x28uy -> I32AtomicRmw16SubU
            | 0x29uy -> I64AtomicRmw8SubU
            | 0x2auy -> I64AtomicRmw16SubU
            | 0x2buy -> I64AtomicRmw32SubU
            | 0x2cuy -> I32AtomicRmwAnd
            | 0x2duy -> I64AtomicRmwAnd
            | 0x2euy -> I32AtomicRmw8AndU
            | 0x2fuy -> I32AtomicRmw16AndU
            | 0x30uy -> I64AtomicRmw8AndU
            | 0x31uy -> I64AtomicRmw16AndU
            | 0x32uy -> I64AtomicRmw32AndU
            | 0x33uy -> I32AtomicRmwOr
            | 0x34uy -> I64AtomicRmwOr
            | 0x35uy -> I32AtomicRmw8OrU
            | 0x36uy -> I32AtomicRmw16OrU
            | 0x37uy -> I64AtomicRmw8OrU
            | 0x38uy -> I64AtomicRmw16OrU
            | 0x39uy -> I64AtomicRmw32OrU
            | 0x3auy -> I32AtomicRmwXor
            | 0x3buy -> I64AtomicRmwXor
            | 0x3cuy -> I32AtomicRmw8XorU
            | 0x3duy -> I32AtomicRmw16XorU
            | 0x3euy -> I64AtomicRmw8XorU
            | 0x3fuy -> I64AtomicRmw16XorU
            | 0x40uy -> I64AtomicRmw32XorU
            | 0x41uy -> I32AtomicRmwXchg
            | 0x42uy -> I64AtomicRmwXchg
            | 0x43uy -> I32AtomicRmw8XchgU
            | 0x44uy -> I32AtomicRmw16XchgU
            | 0x45uy -> I64AtomicRmw8XchgU
            | 0x46uy -> I64AtomicRmw16XchgU
            | 0x47uy -> I64AtomicRmw32XchgU
            | 0x48uy -> I32AtomicRmwCmpxchg
            | 0x49uy -> I64AtomicRmwCmpxchg
            | 0x4auy -> I32AtomicRmw8CmpxchgU
            | 0x4buy -> I32AtomicRmw16CmpxchgU
            | 0x4cuy -> I64AtomicRmw8CmpxchgU
            | 0x4duy -> I64AtomicRmw16CmpxchgU
            | 0x4euy -> I64AtomicRmw32CmpxchgU
            | _      -> failwith "todo"
        | 0x00uy -> Unreachable
        | 0x01uy -> Nop
        | 0x02uy -> Block
        | 0x03uy -> Loop
        | 0x04uy -> If
        | 0x05uy -> Else
        | 0x06uy -> Try
        | 0x07uy -> Catch
        | 0x08uy -> Throw
        | 0x09uy -> Rethrow
        | 0x0auy -> BrOnExn
        | 0x0buy -> End
        | 0x0cuy -> Br (br.ReadVarUInt32())
        | 0x0duy -> BrIf (br.ReadVarUInt32())
        | 0x0euy -> BrTable
        | 0x0fuy -> Return
        | 0x10uy -> Call (br.ReadVarUInt32())
        | 0x11uy -> CallIndirect
        | 0x12uy -> ReturnCall
        | 0x13uy -> ReturnCallIndirect
        | 0x1auy -> Drop
        | 0x1buy -> Select
        | 0x20uy -> LocalGet (br.ReadVarUInt32())
        | 0x21uy -> LocalSet (br.ReadVarUInt32())
        | 0x22uy -> LocalTee
        | 0x23uy -> GlobalGet
        | 0x24uy -> GlobalSet
        | 0x28uy -> I32Load
        | 0x29uy -> I64Load
        | 0x2auy -> F32Load
        | 0x2buy -> F64Load
        | 0x2cuy -> I32Load8S
        | 0x2duy -> I32Load8U
        | 0x2euy -> I32Load16S
        | 0x2fuy -> I32Load16U
        | 0x30uy -> I64Load8S
        | 0x31uy -> I64Load8U
        | 0x32uy -> I64Load16S
        | 0x33uy -> I64Load16U
        | 0x34uy -> I64Load32S
        | 0x35uy -> I64Load32U
        | 0x36uy -> I32Store
        | 0x37uy -> I64Store
        | 0x38uy -> F32Store
        | 0x39uy -> F64Store
        | 0x3auy -> I32Store8
        | 0x3buy -> I32Store16
        | 0x3cuy -> I64Store8
        | 0x3duy -> I64Store16
        | 0x3euy -> I64Store32
        | 0x3fuy -> MemorySize
        | 0x40uy -> MemoryGrow
        | 0x41uy -> I32Const (br.ReadVarInt32())
        | 0x42uy -> I64Const
        | 0x43uy -> F32Const
        | 0x44uy -> F64Const
        | 0x45uy -> I32Eqz
        | 0x46uy -> I32Eq
        | 0x47uy -> I32Ne
        | 0x48uy -> I32LtS
        | 0x49uy -> I32LtU
        | 0x4auy -> I32GtS
        | 0x4buy -> I32GtU
        | 0x4cuy -> I32LeS
        | 0x4duy -> I32LeU
        | 0x4euy -> I32GeS
        | 0x4fuy -> I32GeU
        | 0x50uy -> I64Eqz
        | 0x51uy -> I64Eq
        | 0x52uy -> I64Ne
        | 0x53uy -> I64LtS
        | 0x54uy -> I64LtU
        | 0x55uy -> I64GtS
        | 0x56uy -> I64GtU
        | 0x57uy -> I64LeS
        | 0x58uy -> I64LeU
        | 0x59uy -> I64GeS
        | 0x5auy -> I64GeU
        | 0x5buy -> F32Eq
        | 0x5cuy -> F32Ne
        | 0x5duy -> F32Lt
        | 0x5euy -> F32Gt
        | 0x5fuy -> F32Le
        | 0x60uy -> F32Ge
        | 0x61uy -> F64Eq
        | 0x62uy -> F64Ne
        | 0x63uy -> F64Lt
        | 0x64uy -> F64Gt
        | 0x65uy -> F64Le
        | 0x66uy -> F64Ge
        | 0x67uy -> I32Clz
        | 0x68uy -> I32Ctz
        | 0x69uy -> I32Popcnt
        | 0x6auy -> I32Add
        | 0x6buy -> I32Sub
        | 0x6cuy -> I32Mul
        | 0x6duy -> I32DivS
        | 0x6euy -> I32DivU
        | 0x6fuy -> I32RemS
        | 0x70uy -> I32RemU
        | 0x71uy -> I32And
        | 0x72uy -> I32Or
        | 0x73uy -> I32Xor
        | 0x74uy -> I32Shl
        | 0x75uy -> I32ShrS
        | 0x76uy -> I32ShrU
        | 0x77uy -> I32Rotl
        | 0x78uy -> I32Rotr
        | 0x79uy -> I64Clz
        | 0x7auy -> I64Ctz
        | 0x7buy -> I64Popcnt
        | 0x7cuy -> I64Add
        | 0x7duy -> I64Sub
        | 0x7euy -> I64Mul
        | 0x7fuy -> I64DivS
        | 0x80uy -> I64DivU
        | 0x81uy -> I64RemS
        | 0x82uy -> I64RemU
        | 0x83uy -> I64And
        | 0x84uy -> I64Or
        | 0x85uy -> I64Xor
        | 0x86uy -> I64Shl
        | 0x87uy -> I64ShrS
        | 0x88uy -> I64ShrU
        | 0x89uy -> I64Rotl
        | 0x8auy -> I64Rotr
        | 0x8buy -> F32Abs
        | 0x8cuy -> F32Neg
        | 0x8duy -> F32Ceil
        | 0x8euy -> F32Floor
        | 0x8fuy -> F32Trunc
        | 0x90uy -> F32Nearest
        | 0x91uy -> F32Sqrt
        | 0x92uy -> F32Add
        | 0x93uy -> F32Sub
        | 0x94uy -> F32Mul
        | 0x95uy -> F32Div
        | 0x96uy -> F32Min
        | 0x97uy -> F32Max
        | 0x98uy -> F32Copysign
        | 0x99uy -> F64Abs
        | 0x9auy -> F64Neg
        | 0x9buy -> F64Ceil
        | 0x9cuy -> F64Floor
        | 0x9duy -> F64Trunc
        | 0x9euy -> F64Nearest
        | 0x9fuy -> F64Sqrt
        | 0xa0uy -> F64Add
        | 0xa1uy -> F64Sub
        | 0xa2uy -> F64Mul
        | 0xa3uy -> F64Div
        | 0xa4uy -> F64Min
        | 0xa5uy -> F64Max
        | 0xa6uy -> F64Copysign
        | 0xa7uy -> I32WrapI64
        | 0xa8uy -> I32TruncF32S
        | 0xa9uy -> I32TruncF32U
        | 0xaauy -> I32TruncF64S
        | 0xabuy -> I32TruncF64U
        | 0xacuy -> I64ExtendI32S
        | 0xaduy -> I64ExtendI32U
        | 0xaeuy -> I64TruncF32S
        | 0xafuy -> I64TruncF32U
        | 0xb0uy -> I64TruncF64S
        | 0xb1uy -> I64TruncF64U
        | 0xb2uy -> F32ConvertI32S
        | 0xb3uy -> F32ConvertI32U
        | 0xb4uy -> F32ConvertI64S
        | 0xb5uy -> F32ConvertI64U
        | 0xb6uy -> F32DemoteF64
        | 0xb7uy -> F64ConvertI32S
        | 0xb8uy -> F64ConvertI32U
        | 0xb9uy -> F64ConvertI64S
        | 0xbauy -> F64ConvertI64U
        | 0xbbuy -> F64PromoteF32
        | 0xbcuy -> I32ReinterpretF32
        | 0xbduy -> I64ReinterpretF64
        | 0xbeuy -> F32ReinterpretI32
        | 0xbfuy -> F64ReinterpretI64
        | 0xc0uy -> I32Extend8S
        | 0xc1uy -> I32Extend16S
        | 0xc2uy -> I64Extend8S
        | 0xc3uy -> I64Extend16S
        | 0xc4uy -> I64Extend32S
        | 0xe0uy -> InterpAlloca
        | 0xe1uy -> InterpBrUnless
        | 0xe2uy -> InterpCallHost
        | 0xe3uy -> InterpData
        | 0xe4uy -> InterpDropKeep
        | 0x25uy -> TableGet
        | 0x26uy -> TableSet
        | 0xd0uy -> RefNull
        | 0xd1uy -> RefIsNull
        | _      -> failwith "todo"

