/**
 * Base Object
 */
export default class Base {
    createdAt: Date | undefined

    updatedAt: Date | undefined

    constructor(
        {
            createdAt,
            updatedAt,
        }: {
        /** CreatedAt */
        createdAt?: string
        /** UpdatedAt */
        updatedAt?: string
    }) {
        this.createdAt = createdAt ? new Date(createdAt) : undefined
        this.updatedAt = updatedAt ? new Date(updatedAt) : undefined
    }
}
